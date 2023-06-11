using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HtTotal : MonoBehaviour
{
    private Image content;

    // Start is called before the first frame update
    void Start()
    {
        content = GetComponent<Image>();
        GetHealth();
    }

    public void GetHealth()
    {
        float ht = PlayerPrefs.GetFloat("RemainingHealth", 100); // Mengambil nilai health yang tersimpan dari PlayerPrefs, defaultnya adalah 100f jika tidak ada data tersimpan sebelumnya
        float mx = PlayerPrefs.GetFloat("MaxHealth", 100); // Mengambil nilai max health yang tersimpan dari PlayerPrefs, defaultnya adalah 100f jika tidak ada data tersimpan sebelumnya
        content.fillAmount = ht / mx;
    }
}
