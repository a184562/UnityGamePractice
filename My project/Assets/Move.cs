using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    void Start()
    {
        // int num = 4;                     // 스칼라 값
        // Vector3 vec = new Vector3(1, 1, 1); // 벡터 값
        // transform.Translate(vec);
    }

    void Update()
    {
        // 기본 이동
        // Vector3 vec = new Vector3(0, 0.1f, 0);
        // transform.Translate(vec);

        // 입력 이동
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(vec);
    }
}
