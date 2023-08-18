using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionWithPlayer : MonoBehaviour
{
    //private PhysicsMaterial2D _bouncyMaterial;
    //public PhysicsMaterial2D _defaultMaterial;

    private bool _isParrying;
    [SerializeField] private float _damageForce = 5;

    private void Awake()
    {
        //_bouncyMaterial = GetComponent<Collider2D>().sharedMaterial;
    }

    private void OnEnable()
    {
        PlayerParry.OnParryActive += PlayerParry_OnParryActive;
    }

    private void OnDisable()
    {
        PlayerParry.OnParryActive -= PlayerParry_OnParryActive;

    }
    private void PlayerParry_OnParryActive(bool parryPressed)
    {
        _isParrying = parryPressed;
    }



    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !_isParrying)
        {
            collision.rigidbody.AddForce(Vector2.left * _damageForce, ForceMode2D.Impulse);

        }
        else
        {
            return;

        }
    }

}