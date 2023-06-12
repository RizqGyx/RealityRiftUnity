using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    public DamageableCharacter targetPlayer; 

    private Image content;

    void Start()
    {
        content = GetComponent<Image>();
    }

    void Update()
    {   
        if (targetPlayer != null)
        {
            content.fillAmount = targetPlayer._health / targetPlayer.max_health;
        }
    }
}
