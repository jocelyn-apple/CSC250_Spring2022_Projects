using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update() //kind of like a run method
    {
        //this is the game object that this script is attached to
        //Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        if(Input.GetKeyDown("up"))
        {
            print("up key was pressed");
            rb.velocity = Vector3.forward * speed;
        }
        else if(Input.GetKeyDown("down"))
        {
            print("down key was pressed");
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            print("left key was pressed");
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            print("right key was pressed");
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            rb.velocity = Vector3.up * speed;
        }
    }
}
