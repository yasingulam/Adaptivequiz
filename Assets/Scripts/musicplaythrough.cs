using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicplaythrough : MonoBehaviour
{
    void Awake()
    {
        // Check if an instance of the game object already exists.
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            // If an instance already exists, destroy this instance.
            Destroy(gameObject);
        }
        else
        {
            // If no instance exists, don't destroy this instance when a new scene is loaded.
            DontDestroyOnLoad(gameObject);
        }
    }
}
