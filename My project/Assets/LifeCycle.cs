using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        if(Input.anyKeyDown)
            Debug.Log("�÷��̰� �ƹ� Ű�� �������ϴ�.");
        // if (Input.anyKey)
        //    Debug.Log("�÷��̰� �ƹ� Ű�� ������ �ֽ��ϴ�.");
        // if (Input.GetKeyDown(KeyCode.Return))
        //    Debug.Log("�������� �����߽��ϴ�.");
        // if (Input.GetKey(KeyCode.LeftArrow))
        //    Debug.Log("�������� �̵�");
        // if (Input.GetKeyUp(KeyCode.RightArrow))
        //    Debug.Log("���������� �̵�");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� �߻�");
        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ����");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�");

        if (Input.GetButtonDown("Jump"))
            Debug.Log("����");
        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����");

        if (Input.GetButtonDown("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��" + Input.GetAxisRaw("Horizontal"));
            Input.GetAxis("Horizontal");
        }

        if (Input.GetButtonDown("Vertical"))
        {
            Debug.Log("�� �̵� ��" + Input.GetAxisRaw("Vertical"));
            Input.GetAxis("Vertical");
        }

        //if (Input.GetButtonDown("Horizontal"))
    }

}
