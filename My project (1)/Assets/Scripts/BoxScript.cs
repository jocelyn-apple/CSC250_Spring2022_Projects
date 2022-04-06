using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
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
            count++;
            //print("cube collision enter" + count);
            if(count == 3)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update() //kind of like a run method
    {

    }
}
