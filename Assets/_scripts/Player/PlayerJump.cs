using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    protected PlayerControls playerControls;

    public delegate void Jump(bool jumping);
    public static event Jump OnJump;

    private Rigidbody2D _rigidbody;

    [SerializeField] private float _jumpPower = 5;
    [SerializeField][Range(0f, 0.3f)] private float _jumpBufferLimit = 0.15f;
    [SerializeField] private float _jumpBufferCounter;
    [SerializeField][Range(0f, 0.3f)] private float _coyoteTimeLimit = 0.1f;
    [SerializeField] private float _coyoteTimeCounter;

    private bool _jumpDesired;
    private bool _willJump;
    [SerializeField] private bool _isGrounded;
    private bool _canJump = true;
    [SerializeField] private bool _currentlyJumping;

    [Header("Gravity")]
    [SerializeField] private float _baseGravity;
    [SerializeField][Range(0f, 5f)] private float _jumpGravity;
    [SerializeField][Range(0f, 5f)] private float _fallGravity;

    private void Awake()
    {
        playerControls = new PlayerControls();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerControls.Gameplay.Enable();

        playerControls.Gameplay.Jump.performed += Jump_performed;
        playerControls.Gameplay.Jump.canceled += Jump_canceled;

        CheckPlayerGrounded.OnGrounded += CheckPlayerGrounded_OnGrounded;
        HandlePlayerStun.OnStunned += HandlePlayerStun_OnStunned;
    }

    private void OnDisable()
    {
        playerControls.Gameplay.Disable();

        playerControls.Gameplay.Jump.performed -= Jump_performed;
        playerControls.Gameplay.Jump.canceled -= Jump_canceled;

        CheckPlayerGrounded.OnGrounded -= CheckPlayerGrounded_OnGrounded;
        HandlePlayerStun.OnStunned -= HandlePlayerStun_OnStunned;
    }

    private void Start()
    {
        _baseGravity = _rigidbody.gravityScale;
    }

    private void FixedUpdate()
    {
        HandleJumpBuffering();
        HandleCoyoteTime();
        SetJumpGravity();

        // Perform the jump in FixedUpdate
        if (_willJump)
        {
            _willJump = false;
            DoJump();
        }
    }

    private void Jump_performed(InputAction.CallbackContext obj)
    {
        if (Time.timeScale == 0)
        {
            return;
        }
        else
        {
            if (_canJump && _isGrounded)
            {
                _willJump = true; // Set the flag to request a jump
            }
            if (!_isGrounded)
            {
                _jumpDesired = true;
            }
        }
    }

    private void Jump_canceled(InputAction.CallbackContext obj)
    {
        _coyoteTimeCounter = 0;
        OnJump?.Invoke(false);
    }

    private void CheckPlayerGrounded_OnGrounded(bool grounded)
    {
        _isGrounded = grounded;
        if (_isGrounded) _currentlyJumping = false;
        ResetGravity();
    }

    private void HandlePlayerStun_OnStunned(bool stunned)
    {
        _canJump = !stunned;
    }

    private void HandleJumpBuffering()
    {
        if (Time.timeScale == 0)
        {
            return;
        }
        else
        {
            if (!_jumpDesired)
            {
                _jumpBufferCounter = 0;
            }
            else
            {
                _jumpBufferCounter += Time.deltaTime;

                if (_isGrounded && _jumpBufferCounter <= _jumpBufferLimit)
                {
                    _jumpBufferCounter = 0;
                    _jumpDesired = false;
                    _willJump = true; // Set the flag to request a jump
                }
                else if (_jumpBufferCounter > _jumpBufferLimit)
                {
                    _jumpBufferCounter = 0;
                    _jumpDesired = false;
                }
            }
        }
    }

    private void HandleCoyoteTime()
    {
        if (_isGrounded) _coyoteTimeCounter = _coyoteTimeLimit;
        else _coyoteTimeCounter -= Time.deltaTime;

        if (_coyoteTimeCounter > 0 && _jumpDesired && !_currentlyJumping) _willJump = true; // Set the flag to request a jump
    }

    private void SetJumpGravity()
    {
        if (_rigidbody.velocity.y > 0 && !_isGrounded) SetNewGravity(_jumpGravity);
        else if (_rigidbody.velocity.y < 0 && !_isGrounded) SetNewGravity(_fallGravity);
        else ResetGravity();
    }

    private void SetNewGravity(float gravityMultiplier)
    {
        _rigidbody.gravityScale *= gravityMultiplier;
    }

    private void ResetGravity()
    {
        _rigidbody.gravityScale = _baseGravity;
    }

    private void DoJump()
    {
        if (Time.timeScale == 0)
        {
            return;
        }
        else
        {
            Vector2 jumpForce = new(0, _jumpPower);

            _currentlyJumping = true;

            OnJump?.Invoke(true);
            _rigidbody.velocity = new(_rigidbody.velocity.x, 0);
            _rigidbody.AddForce(jumpForce, ForceMode2D.Impulse);
        }
    }
}
