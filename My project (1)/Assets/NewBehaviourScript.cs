using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    Vector3 goUp;
    float speed;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        goUp = new Vector3(0.0f, 1.0f, 0.0f);
        speed = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //this is the game object that this script is attached to
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        rb.velocity = goUp * speed;
    }
}
