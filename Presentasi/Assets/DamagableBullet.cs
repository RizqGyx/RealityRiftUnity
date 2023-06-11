using UnityEngine;

public class DamagableBullet : MonoBehaviour
{
    public float damage = 1f; // Damage value of the bullet

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has a DamageableCharacter script attached
        DamageableCharacter damageableCharacter = collision.gameObject.GetComponent<DamageableCharacter>();
        if (damageableCharacter != null)
        {
            // Apply damage to the character when hit by the bullet
            damageableCharacter.OnHit(damage);

            // Destroy the bullet
            Destroy(gameObject);
        }
    }
}
