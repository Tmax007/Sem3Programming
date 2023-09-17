using UnityEngine;
using System.Collections;

public class BombSpiral : MonoBehaviour
{
    public GameObject BombPrefab;
    [Range(5, 25)]
    public float SpiralAngleInDegrees = 10;
    public int BombCount = 10;
    public float StartRadius = 1;
    public float EndRadius = 3;

    /// <summary>
    /// Spawns spirals of BombPrefab game objects around the player. Create BombCount number of bombs 
    /// around the player, with each bomb being spaced SpiralAngleInDegrees apart from the next. The spiral 
    /// starts at StartRadius away from the player and ends at EndRadius away from the player.
    /// </summary>
    /// <returns>An array of the spawned bombs</returns>
    public GameObject[] SpawnBombSpiral()
    {
        GameObject[] daBomb = new GameObject[BombCount];

        // Angle increment for even spacing
        float angleInc = SpiralAngleInDegrees;

        // Radius spiral distance
        float radSpiral = (EndRadius - StartRadius) / BombCount;

        for (int i = 0; i < BombCount; i++)
        {
            // Angle for da bomb
            float angle = i * angleInc;

            // Angle to radian
            float rad = angle * Mathf.Deg2Rad;

            // Current radius
            float currentRad = StartRadius + i * radSpiral;

            // Position of bomb in spiral
            float x = transform.position.x + currentRad * Mathf.Cos(rad);
            float y = transform.position.y + currentRad * Mathf.Sin(rad);  

            // Da bomb at calculated position
            daBomb[i] = Instantiate(BombPrefab, new Vector3(x, y), Quaternion.identity);
        }

        return daBomb;
    }

}
