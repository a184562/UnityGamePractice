using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        if(Input.anyKeyDown)
            Debug.Log("플레이가 아무 키를 눌렀습니다.");
        // if (Input.anyKey)
        //    Debug.Log("플레이가 아무 키를 누르고 있습니다.");
        // if (Input.GetKeyDown(KeyCode.Return))
        //    Debug.Log("아이템을 구입했습니다.");
        // if (Input.GetKey(KeyCode.LeftArrow))
        //    Debug.Log("왼쪽으로 이동");
        // if (Input.GetKeyUp(KeyCode.RightArrow))
        //    Debug.Log("오른쪽으로 이동");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사");
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 장전");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사");

        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프");
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프");

        if (Input.GetButtonDown("Horizontal"))
        {
            Debug.Log("횡 이동 중" + Input.GetAxisRaw("Horizontal"));
            Input.GetAxis("Horizontal");
        }

        if (Input.GetButtonDown("Vertical"))
        {
            Debug.Log("종 이동 중" + Input.GetAxisRaw("Vertical"));
            Input.GetAxis("Vertical");
        }

        //if (Input.GetButtonDown("Horizontal"))
    }

}
