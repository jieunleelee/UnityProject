using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LJE_PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 20;
    public float jumpAmount = 10;
    public bool isGrounded = false;
    public int jumpCount = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpCount = 0;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true; // Ground에 닿으면 isGrounded는 true
            jumpCount = 2; // Ground에 닿으면 점프횟수가 2로 초기화됨
        }
    }

    void Update()
    {
        if (isGrounded)
        {
            if (jumpCount > 0)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
                    jumpCount--; // 점프할 때마다 점프 횟수 감소
                }
            }
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        dir = new Vector3(h, 0, v);


    }
    Vector3 dir;
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + dir * speed * Time.deltaTime);
    }

}

