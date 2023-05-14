using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Move : MonoBehaviour
{
    
    Rigidbody rigid;

    public int JumpPower;
    public int MoveSpeed;

    int isJump;

    void Start()
    {
        // int num = 4;                     // 스칼라 값
        // Vector3 vec = new Vector3(1, 1, 1); // 벡터 값
        // transform.Translate(vec);
        rigid = GetComponent<Rigidbody>();
        isJump = 0;
    }

    void Update()
    {
        // 기본 이동
        // Vector3 vec = new Vector3(0, 0.1f, 0);
        // transform.Translate(vec);

        // 입력 이동
        // Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        // transform.Translate(vec);
        Moving();
        Jump();
    }
    void Moving()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        transform.Translate((new Vector3(x, 0, z) * MoveSpeed) * Time.deltaTime);
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJump = 0;
        }
    }
    
    /*
    Vector3 target = new Vector3(8, 1.5f, 0);

    private void Update()
    {
        // 1. MoveTowards
        // transform.position = Vector3.MoveTowards(transform.position, target, 2f);

        // 2. SmoothDamp
        // Vector3 velo = Vector3.zero;

        // transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        // 3. Lerp
        // transform.position = Vector3.Lerp(transform.position, target, 0.005f);

        // 4. SLerp
        // transform.position = Vector3.Slerp(transform.position, target, 0.005f);
    }
    */

    
}
