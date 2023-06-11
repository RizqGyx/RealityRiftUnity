using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public static int point = 0;
    
    [SerializeField] private Text chestText;

    private DamageableCharacter playerDamageable;


    void Start()
    {
        playerDamageable = GetComponent<DamageableCharacter>();
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Chest")) 
        {
            Destroy(collision.gameObject);
            point += 100;
            chestText.text = "Point : " + point;
        }
        else if (collision.gameObject.CompareTag("Slime")) 
        {
            DamageableCharacter slime = collision.gameObject.GetComponent<DamageableCharacter>();
            if (slime != null && slime.Health <= 0) 
            {
                point += 50;
                chestText.text = "Point : " + point;
            }
        }else if (collision.gameObject.CompareTag("HealthPotion"))
        {
            if (playerDamageable != null)
            {
                playerDamageable.IncreaseHealth(20); // Assuming you have a method to increase the player's health in the DamageableCharacter script
                Destroy(collision.gameObject);
            }
}
    }
}

