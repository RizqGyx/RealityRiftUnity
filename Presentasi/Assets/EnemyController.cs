using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject[] enemyVariants; // or List<GameObject> enemyVariants;

    // ... Other enemy logic ...

    public void ClearEnemyVariants()
    { 
        Debug.Log("Clearing enemy variants");
        // Clear the enemy variants
        enemyVariants = new GameObject[0]; // or enemyVariants.Clear();
    }
}
