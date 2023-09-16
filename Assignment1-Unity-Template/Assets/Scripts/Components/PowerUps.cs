using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour
{
    public GameObject PowerUpPrefab;
    public int PowerUpCount = 3;
    public float PowerUpRadius = 1;

    /// <summary>
    /// Spawn a circle of PowerUpCount power up prefabs stored in PowerUpPrefab, evenly spaced, around the player with a radius of PowerUpRadius
    /// </summary>
    /// <returns>An array of the spawned power ups, in counter clockwise order.</returns>
    public GameObject[] SpawnPowerUps()
    {
        GameObject[] powerUps = new GameObject[PowerUpCount];

        // Angle increment for even spacing
        float angleInc = 360 / PowerUpCount;

        for (int i = 0; i < PowerUpCount; i++)
        {
            // Angle for power up
            float angle = i * angleInc;

            // Angle to radian
            float rad = angle * Mathf.Deg2Rad;

            // Position of power up in circle
            float x = transform.position.x + PowerUpRadius * Mathf.Cos(rad);
            float y = transform.position.y + PowerUpRadius* Mathf.Sin(rad);

            // Powerup at calculated position
            powerUps[i] = Instantiate(PowerUpPrefab, new Vector3(x, y), Quaternion.identity);
        }

        return powerUps;
    }
}
