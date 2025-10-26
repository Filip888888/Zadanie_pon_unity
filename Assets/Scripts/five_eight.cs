using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;

public class five_eight : MonoBehaviour
{

    public Vector3 center = Vector3.zero; 
    public float radius = 2f;
    public GameObject sun1;
    public GameObject sun2;
    public float speed = 50f;             
    private float angle = 0f;
    private float offsetAngle = 180f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        angle += speed * Time.deltaTime;

        
        float rad1 = Mathf.Deg2Rad * angle;
        float rad2 = Mathf.Deg2Rad * (angle + offsetAngle);
        
        sun1.transform.position = center + new Vector3(Mathf.Cos(rad1) * radius, 0, Mathf.Sin(rad1) * radius);
        sun2.transform.position = center + new Vector3(Mathf.Cos(rad2) * radius, 0, Mathf.Sin(rad2) * radius);
    }
}
