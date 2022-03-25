using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LJE_3rdCandle : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
    
    }



    // Update is called once per frame

    void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.name.Contains("Player"))

        {
            rigid = GetComponent<Rigidbody>();
            rigid.velocity = Vector3.right;
            print("AAA");
        }

    
        if (collision.gameObject.name.Contains("BridgeEdge"))
        {
            // rigid.velocity = new Vector3(0, 0, 0);
            rigid.isKinematic = true;
            rigid.useGravity = false;
            print("ZZZ");
        }
    }
        

}