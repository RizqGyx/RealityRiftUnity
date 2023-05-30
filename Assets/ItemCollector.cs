using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int chest = 0;

    [SerializeField] private Text chestText;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Chest")) 
        {
            Destroy(collision.gameObject);
            chest += 100;
            chestText.text = "Point : " + chest;
        }
    }
}
