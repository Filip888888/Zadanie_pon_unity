using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;

public class five_twelve : MonoBehaviour
{
    public float speed_earth = 50f;
    public float speed_sun = 40f;
    private float radius = 2f;
    private float angle = 0;
    private float rotate = 0;
    public GameObject earth;
    public GameObject sun;
    private Vector3 center = new Vector3(5f, 2f, 0f);
    private Vector3 Offset = new Vector3(5f, 0f, 0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sun.transform.position = center;
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed_earth * Time.deltaTime;
        rotate += speed_sun * Time.deltaTime;
        float r = Mathf.Deg2Rad * angle;

        earth.transform.position = center + new Vector3(Mathf.Cos(r) * radius, 0, Mathf.Sin(r) * radius);
        sun.transform.rotation = Quaternion.Euler(0, rotate, 0);
        earth.transform.rotation = Quaternion.Euler(0, rotate, 0);
    }
}
