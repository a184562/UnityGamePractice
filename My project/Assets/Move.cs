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
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

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

}
