using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{

    public GameObject cube;
    private float Speed=1f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        cube.transform.position += new Vector3(0.1f, 0f, 0f) * Speed* Time.deltaTime ;
    }
}
