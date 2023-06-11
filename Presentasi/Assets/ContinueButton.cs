using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    public GameObject youWinCanvas; // Reference to the "You Win" canvas game object
    public GameObject enemyObject; // Reference to the Enemy game object

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
        // SceneManager.LoadScene("NextSceneName");
    }
}
