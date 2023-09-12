using UnityEngine;
using System.Collections;

public class VectorToEnemy : MonoBehaviour
{
    void Update()
    {
        // Press to return vector from player to the enemy
        if (Input.GetKeyDown(KeyCode.V))
        {
            DisplayVector();
        }

        // Press to return distance between player to the enemy
        if (Input.GetKeyDown(KeyCode.D))
        {
            DisplayDistance();
        }
    }

    /// <summary>
    /// Calculated vector from the player to enemy found by GameManager.GetEnemyObject
    /// </summary>
    /// <see cref="GameController.GetEnemyObject"/>
    /// <returns>The vector from the player to the enemy.</returns>
    public Vector3 GetVectorToEnemy()
    {
        // Player's position
        Vector3 playerPosition = transform.position;

        // Enemy's position
        Vector3 enemyPosition = GameController.GetEnemyObject().transform.position;

        // Vector from player to enemy
        Vector3 vectorToEnemy = enemyPosition - playerPosition;

        return vectorToEnemy;
        //return Vector3.zero; 
    }

    /// <summary>
    /// Calculates the distance from the player to the enemy returned by GameManager.GetEnemyObject.
    /// </summary>
    /// <see cref="GameController.GetEnemyObject"/>
    /// <returns>The scalar distance between the player and the enemy</returns>
    public float GetDistanceToEnemy()
    {
        // Get vector from player to the enemy
        Vector3 vectorToEnemy = GetVectorToEnemy();

        // Squared distance
        float squaredDistance = Mathf.Pow(vectorToEnemy.x, 2) + Mathf.Pow(vectorToEnemy.y, 2);

        // Return actual distance
        float distance = Mathf.Sqrt(squaredDistance);

        return distance;
    }

    void DisplayVector()
    {
        // Vector from player to enemy
        Vector3 vectorToEnemy = GetVectorToEnemy();

        // Display vector on Console
        Debug.Log("Vector to Enemy: " + vectorToEnemy.ToString());
    }

    void DisplayDistance()
    {
        // Distance from player to enemy
        float distance = GetDistanceToEnemy();

        // Display distance on Console
        Debug.Log("Distance to Enemy: " + distance.ToString()); 
    }
}
