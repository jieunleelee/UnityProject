using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LJE_1stStairsMove : MonoBehaviour
{
    public float rotSpeed = 100f;



    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        // 1stStairs�� Player�� ������ 
        if (collision.gameObject.name.Contains("Player"))

        {
            print("������");
            transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
            
        }
        
    }
}
