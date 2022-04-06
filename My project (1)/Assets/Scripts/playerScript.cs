using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private Player thePlayer;
    public float speed = 2.0f;
    private Rigidbody rb;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        thePlayer = new Player("Jocelyn");
    }

    public void DoSomething()
    {
        print("Do something called");
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Enemy"))
        {
            print("player collision enter");
            count++;
            if(count == 3)
            {
                this.thePlayer.addKill();
                print("Kill count: " + this.thePlayer.getKillCount());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //print(thePlayer.getName());

        if (Input.GetKeyDown("up"))
        {
            //print("up key was pressed");
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            //print("down key was pressed");
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            //print("left key was pressed");
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            //print("right key was pressed");
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            //print("space key was pressed");
            rb.velocity = Vector3.up * speed;
        }
    }
}
