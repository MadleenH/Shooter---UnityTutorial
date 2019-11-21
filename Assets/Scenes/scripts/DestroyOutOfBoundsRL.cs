using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsRL : MonoBehaviour
{
    private float rightBound = -60;
    private float leftBound = 45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > leftBound){
            Destroy(gameObject);
        }
        else if (transform.position.x < rightBound){
            Destroy(gameObject);
            }
    }
}
