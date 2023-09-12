using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPrefabRelative : MonoBehaviour
{
    public GameObject Prefab;
    public Vector3 SpawnOffset;

    /// <summary>
    /// Instantiates the game object stored in the variable Prefab at SpawnOffset distance away from the player. The object is a 
    /// root object.
    /// </summary>
    /// <returns>The newly spawned object in the right position.</returns>

    void Update()
    {
        // Press O to  spawn
        if (Input.GetKeyDown(KeyCode.O))
        {
            PositionPrefabAtRelativePosition();
        }
    }
    public GameObject PositionPrefabAtRelativePosition()
    {
        // Player's position
        Vector3 playerPosition = transform.position;

        // Spawn position based on the player's forward direction and SpawnOffset
        Vector3 SpawnPosition = playerPosition + transform.forward + SpawnOffset;

        // Create object at spawn position
        GameObject SpawnedObj = Instantiate(Prefab, SpawnPosition, Quaternion.identity);

        // Not parented to anything
        SpawnedObj.transform.parent = null;

        return SpawnedObj;
    }
    
}
