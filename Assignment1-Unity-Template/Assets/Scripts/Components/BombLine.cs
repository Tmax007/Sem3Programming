using UnityEngine;
using System.Collections;

public class BombLine : MonoBehaviour
{

    public GameObject BombPrefab;
    public int BombCount;
    public float BombSpacing;

    void Update()
    {
        //Press B to spawn bombs
        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnBombs();
        }
    }
    /// <summary>
    /// Spawn a line of instantiated BombPrefabs behind the player ship. There should be BombCount bombs placed with BombSpacing amount of space between them.
    /// </summary>
    /// <returns>An array containing all the bomb objects</returns>
    public GameObject[] SpawnBombs()
    {
        GameObject[] bombArray = new GameObject[BombCount];

        // Player's position
        Vector3 playerPosition = transform.position;

        // Initial position behind player
        Vector3 initialPosition = playerPosition - transform.up * BombSpacing;

        // Instantiate and store bomb objects
        for (int i = 0; i < BombCount; i++)
        {
            // Position of the current bomb in line
            Vector3 bombPosition = initialPosition - transform.up * i * BombSpacing;

            // Instantiate bomb prefab at calculated position
            bombArray[i] = Instantiate(BombPrefab, bombPosition, Quaternion.identity);
        }

        return bombArray;
    }
}
