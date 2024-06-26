using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEffects : MonoBehaviour
{
    [SerializeField] private GameObject _parryEffectPrefab; // Prefab for the parry effect
    [SerializeField] private GameObject _collisionEffectPrefab; // Prefab for the collision effect
    [SerializeField] private GameObject _deathEffectPrefab; // Prefab for the parry effect
    private bool _parryActive;
    private bool _playerDead = false;

    private void OnEnable()
    {
        PlayerParry.OnParryActive += PlayerParry_OnParryActive;
        HandlePlayerHealth.OnPlayerDead += HandlePlayerHealth_OnPlayerDead;
    }

    private void OnDisable()
    {
        PlayerParry.OnParryActive -= PlayerParry_OnParryActive;
        HandlePlayerHealth.OnPlayerDead -= HandlePlayerHealth_OnPlayerDead;
    }

    private void PlayerParry_OnParryActive(bool parryActive)
    {
        _parryActive = parryActive;
    }

    private void HandlePlayerHealth_OnPlayerDead()
    {
        _playerDead = true;
        Instantiate(_deathEffectPrefab, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_playerDead)
        {
            return;
        }

        if (_parryActive && (collision.CompareTag("HurtBox") || collision.CompareTag("Projectile")))
        {
            // Instantiate the parry effect
            GameObject parryEffectInstance = Instantiate(_parryEffectPrefab, transform.position, Quaternion.identity);

            // get the angle of the parry and set the rotation of the effect
            Vector3 targetDir = collision.transform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
            parryEffectInstance.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            // Destroy the instantiated effect after a delay
            Destroy(parryEffectInstance, 0.2f);
        }
        else if (!_parryActive && (collision.CompareTag("HurtBox") || collision.CompareTag("Projectile") || collision.CompareTag("Enemy")))
        {
            // Instantiate collision effect
            GameObject collisionEffectInstance = Instantiate(_collisionEffectPrefab, transform.position, Quaternion.identity);

            // get the angle of the parry and set the rotation of the effect
            Vector3 targetDir = collision.transform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
            collisionEffectInstance.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            // Destroy the instantiated effect after a delay
            Destroy(collisionEffectInstance, 2f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!_parryActive && collision.gameObject.CompareTag("Enemy"))
        {
            GameObject collisionEffectInstance = Instantiate(_collisionEffectPrefab, transform.position, Quaternion.identity);

            // get the angle of the parry and set the rotation of the effect
            Vector3 targetDir = collision.transform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
            collisionEffectInstance.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            // Destroy the instantiated effect after a delay
            Destroy(collisionEffectInstance, 2f);
        }
    }
}
