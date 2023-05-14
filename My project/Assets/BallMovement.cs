using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rigid;
    int isJump;
    public int JumpPower = 25;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        // rigid.velocity = Vector3.right;
        // rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        // rigid.velocity = new Vector3(2, 4, 3);
        
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 150, ForceMode.Impulse);
        }
        
        
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);

        // Jump();

        // 회전력주기
        // rigid.AddTorque(Vector3.back);


    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube (2)")
        {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        }
    }
    /*
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJump < 2)
            {
                isJump++;
                rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
            }
            else
            {
                return;
            }
        }
    }
    */
}
