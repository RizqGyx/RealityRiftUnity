using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene : MonoBehaviour
{
    public void LoadGame(){
        SceneManager.LoadScene("TestLevel");
    }
}
