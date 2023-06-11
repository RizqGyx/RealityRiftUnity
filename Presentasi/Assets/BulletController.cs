using UnityEngine;

public class BulletController : MonoBehaviour
{
    public ProjectileSpawner projectileSpawner;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Slime"))
        {
            // Spawn the projectile using the ProjectileSpawner component
            projectileSpawner.SpawnProjectile();

            // Destroy the bullet
            Destroy(gameObject);
        }
    }
}
