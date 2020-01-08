using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
	
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;
    public float zRange = 10.0f;

    public GameObject projectilePrefab;

    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          //creating boundaries for player x-axis
        if(transform.position.x < -xRange) {
            //if true, keep x bound position
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //creating boundaries for player z-axis
        if(transform.position.z < -zRange) {
            //if true, keep z bound position
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if(transform.position.z > zRange) {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }


         // get input from left and right arrow keys
        horizontalInput = Input.GetAxis("Horizontal");

        // Translate position on x-axis
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // get input from up and down arrow keys
        verticalInput = Input.GetAxis("Vertical");

        // Translate position on z-axis
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // let character walk - set input float of horizontal and vertical input to Speed_f float on animator controller
        playerAnim.SetFloat("Speed_f", (Mathf.Abs(horizontalInput+verticalInput/2)));


        if (Input.GetKeyDown(KeyCode.Space)) {
            // Launch Food from player
            Debug.Log("Space key was pressed.");
        }

        if (Input.GetKeyUp(KeyCode.Space)) {
            // Launch Food from player
            Instantiate(projectilePrefab,transform.position, projectilePrefab.transform.transform.rotation);
            Debug.Log("Food was shot.");
        }
    }
}
