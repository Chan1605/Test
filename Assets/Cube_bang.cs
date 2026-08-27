using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_bang : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 90f * Time.deltaTime);
    }
}
