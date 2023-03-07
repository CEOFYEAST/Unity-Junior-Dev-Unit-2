using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    void Update()
    {
        if(transform.position.z > topBound){
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound){
            //ends the game if an animal passes the lower bounds of the screen
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
