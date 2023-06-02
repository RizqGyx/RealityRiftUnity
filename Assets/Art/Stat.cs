using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    public DamageableCharacter targetPlayer; // Reference to the specific player

    private Image content;

    // Start is called before the first frame update
    void Start()
    {
        content = GetComponent<Image>();

        // Make sure to assign the target player reference in the Inspector or via code
    }

    // Update is called once per frame
    void Update()
    {   
        if (targetPlayer != null)
        {
            content.fillAmount = targetPlayer._health / targetPlayer.max_health;
        }
    }
}
