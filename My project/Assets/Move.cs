using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    void Start()
    {
        // int num = 4;                     // ��Į�� ��
        // Vector3 vec = new Vector3(1, 1, 1); // ���� ��
        // transform.Translate(vec);
    }

    void Update()
    {
        // �⺻ �̵�
        // Vector3 vec = new Vector3(0, 0.1f, 0);
        // transform.Translate(vec);

        // �Է� �̵�
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(vec);
    }
}
