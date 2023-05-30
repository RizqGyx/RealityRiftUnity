using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int point = 0;
    
    [SerializeField] private Text chestText;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Chest")) 
        {
            Destroy(collision.gameObject);
            point += 100;
            chestText.text = "Point : " + point;
        }
    }
}
