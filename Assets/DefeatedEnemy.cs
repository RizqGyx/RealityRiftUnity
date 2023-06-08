using UnityEngine;

public class DefeatedEnemy: MonoBehaviour
{
    public GameObject Enemy;
    public GameObject youWinCanvas;

    private void Update()
    {
        // Check if there are no more variants of the enemy
        if (Enemy.transform.childCount == 0)
        {
            // Enable the "You Win" canvas
            youWinCanvas.SetActive(true);
        }
    }
}
