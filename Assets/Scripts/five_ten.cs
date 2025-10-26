using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;


public class five_ten : MonoBehaviour
{

    public float speed = 50f;
    private float radius = 2f;
    private float angle = 0;
    private Vector3 center = new Vector3(10f, 2f, 0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        float r = Mathf.Deg2Rad * angle;
        transform.position = center + new Vector3(Mathf.Cos(r) * radius, 0, Mathf.Sin(r) * radius);
    }
}
