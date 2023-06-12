using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public float damage = 1;
    public float knockbackForce = 20f;
    public float moveSpeed = 500f;

    public DetectionZone detectionZone;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    DamageableCharacter damagableCharacter;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        damagableCharacter = GetComponent<DamageableCharacter>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate() {
        if(damagableCharacter.Targetable && detectionZone.detectedObjs.Count > 0) {
            Vector2 direction = (detectionZone.detectedObjs[0].transform.position - transform.position).normalized;

            if (direction.x > 0)
            {
                spriteRenderer.flipX = false;
            }
            else if (direction.x < 0)
            {
                spriteRenderer.flipX = true;
            }

            rb.AddForce(direction * moveSpeed * Time.fixedDeltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        Collider2D collider = collision.collider;
        IDamageable damageable = collider.GetComponent<IDamageable>();

        if(damageable != null) {
            Vector2 direction = (collider.transform.position - transform.position).normalized;

            Vector2 knockback = direction * knockbackForce;

            damageable.OnHit(damage, knockback);
        }
    }
}