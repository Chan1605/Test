using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCtrl : MonoBehaviour
{
    private Rigidbody rb;
    private float Speed = 10f;
    private float h;
    private float v;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TryGetComponent(out rb);
       
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if(h != 0 || v!= 0)
        {
            Vector3 dir = new Vector3(h, 0, v);
            rb.MovePosition(rb.position + dir * Speed * Time.deltaTime);
        }


    }
}
