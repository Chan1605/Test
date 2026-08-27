using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ahahahah : MonoBehaviour
{
    [SerializeField]private float RotateSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RotateSpeed = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, RotateSpeed * Time.deltaTime, 0f);
    }
}
