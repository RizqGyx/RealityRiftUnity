using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject projectilePrefab; // Drag the projectile prefab to this field in the inspector
    public float projectileForce = 10f;

    public void SpawnProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        // Apply force to the spawned projectile
        if (rb != null)
        {
            rb.AddForce(transform.right * projectileForce, ForceMode2D.Impulse);
        }
    }
}
