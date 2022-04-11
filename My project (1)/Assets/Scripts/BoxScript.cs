using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public float forceMult = 200;
    private Rigidbody rb;
    private int count;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        count = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            CORE.display();
            count++;
            //print("cube collision enter" + count);
            if(count == 3)
            {
                Destroy(this.gameObject);
            }
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() //kind of like a run method
    {
        rb.velocity = transform.forward * Time.deltaTime * forceMult;
    }
}
