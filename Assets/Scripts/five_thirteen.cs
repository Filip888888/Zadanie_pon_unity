using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;

public class five_thirteen : MonoBehaviour
{
    public float speed_earth = 50f;
    public float speed_sun = 40f;
    public float speed_moon = 70f;
    private float radius = 2f;
    private float angle = 0f;
    private float moon_angle= 0f;
    private float moon_radius = 1f;
    private float rotate = 0;
    public GameObject earth;
    public GameObject sun;
    public GameObject moon;
    private Vector3 center = new Vector3(15f, 2f, 0f);
    private Vector3 offset = new Vector3(5f, 0f, 0f);
    private Vector3 moon_Offset = new Vector3(1f, 0f, 0f);
    private Vector3 moon_center;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sun.transform.position = center;
        moon.transform.position = earth.transform.position + moon_Offset;
    }

    // Update is called once per frame
    void Update()
    {
        moon_center = earth.transform.position;
        moon_angle += speed_moon * Time.deltaTime;
        angle += speed_earth * Time.deltaTime;
        rotate += speed_sun * Time.deltaTime;
        float r = Mathf.Deg2Rad * angle;
        float r_m = Mathf.Deg2Rad * moon_angle;

        earth.transform.position = center + new Vector3(Mathf.Cos(r) * radius, 0, Mathf.Sin(r) * radius);
        sun.transform.rotation = Quaternion.Euler(0, rotate, 0);
        earth.transform.rotation = Quaternion.Euler(0, rotate, 0);
        moon.transform.position = moon_center + new Vector3(Mathf.Cos(r_m) * moon_radius, 0, Mathf.Sin(r_m) * moon_radius);
    } 
}
