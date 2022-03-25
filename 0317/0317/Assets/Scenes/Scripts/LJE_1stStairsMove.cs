using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LJE_1stStairsMove : MonoBehaviour
{
    public float rotSpeed = 100f;



    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        // 1stStairs가 Player에 닿으면 
        if (collision.gameObject.name.Contains("Player"))

        {
            print("이지은");
            transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
            
        }
        
    }
}
