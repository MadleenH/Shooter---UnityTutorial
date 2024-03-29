﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    
    public float topBound = 35;
    public float bottomBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound) 
	// Destroy game object after reaching top bound variable
        {
            Destroy(gameObject);
        }
      
        
		else if (transform.position.z < bottomBound)
		{
			// Destroy gameObject
			Debug.Log("GAME OVER");
			
			Destroy(gameObject);
		}
    }
}
