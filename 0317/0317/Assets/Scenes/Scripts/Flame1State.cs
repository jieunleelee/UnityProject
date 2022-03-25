using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame1State : MonoBehaviour
{
    
    public GameObject Flame1;
    private void OnCollisionEnter(Collision collision)
    {
        // 초가 "BridgeEdge"에 닿으면 
        if (collision.gameObject.name.Contains("BridgeEdge"))
        {
            // Flame1이 꺼진다.
            
            Flame1.SetActive(false);
            print("turn off");
        }
    }
}