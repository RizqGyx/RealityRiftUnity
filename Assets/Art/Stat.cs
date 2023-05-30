using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    private Image content;
    private DamageableCharacter healthBar;

    // Start is called before the first frame update
    void Start()
    {
        content = GetComponent<Image>();
        DamageableCharacter healthBar = GetComponent<DamageableCharacter>();
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
}
