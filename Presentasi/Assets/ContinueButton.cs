using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public GameObject youWinCanvas; // Reference to the "You Win" canvas game object
    public GameObject enemyObject; // Reference to the Enemy game object
    public string sceneToLoad;

    public void OnContinueButtonClick()
    {
        DefeatedEnemy defeatedEnemy;
        Debug.Log("Continue button clicked");
        defeatedEnemy = enemyObject.GetComponent<DefeatedEnemy>();
        defeatedEnemy.enabled = false;

        // Deactivate the "You Win" canvas
        youWinCanvas.SetActive(false);

        // Clear the enemy variants
        enemyObject.GetComponent<EnemyController>().ClearEnemyVariants();

        // Optional: Go to another scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
