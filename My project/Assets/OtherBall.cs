using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer Mesh;
    Material Mat;
    void Start()
    {
        Mesh = GetComponent<MeshRenderer>();
        Mat = Mesh.material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "MyBall")
        {
            Mat.color = new Color(0, 0, 0);
        }
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "MyBall")
        {
            Mat.color = new Color(1, 1, 1);
        }
    }
}
