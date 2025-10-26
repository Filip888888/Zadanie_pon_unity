using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;


public class five_nine : MonoBehaviour
{
    
    private Vector3 center1 = Vector3.zero;
    private Vector3 center2 = new Vector3(-6, 0, 0);
    public GameObject star1;
    public GameObject star2;
    private float radius = 5f;
    private float angle1 = 0f;
    private float angle2 = 0f;
    public float speed = 50f;
    private float Offset = 180f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle1 += speed * Time.deltaTime;
        angle2 += speed * Time.deltaTime;
        float r1 = Mathf.Deg2Rad * angle1;
        float r2 = Mathf.Deg2Rad * (angle2 + Offset);
        star1.transform.position = center1 + new Vector3(Mathf.Cos(r1) * radius, 0, Mathf.Sin(r1) * radius);
        star2.transform.position = center2 + new Vector3(Mathf.Cos(r2) * radius, 0, Mathf.Sin(r2) * radius);
    }
}
