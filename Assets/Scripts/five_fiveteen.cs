using System.Collections;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;

public class five_fiveteen : MonoBehaviour
{

    public GameObject left;
    public GameObject cube;
    private float radius = 5;
    public GameObject right;
    public float speed = 40f;
    private Vector3 center;
    private float rotate_anglel = 0f;
    private float rotate_angler = 0f;
    private float anglel = 0;
    private float angler = 360;
    private float direction = 1;
    private float directionr = 1;
    private float Offset = 180;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        left.transform.position = new Vector3(68.11f, 8.96f, 4.56f);
        right.transform.position = new Vector3(82.11f, 8.96f, 4.56f);
        cube.transform.position = new Vector3(75.11f, 8.96f, 4.55f);
    }

    // Update is called once per frame
    void Update()
    {
        center = cube.transform.position;
        anglel += speed * Time.deltaTime * direction; //l
        angler += speed * Time.deltaTime * directionr;
        rotate_anglel += speed * Time.deltaTime * direction;
        rotate_angler -= speed * Time.deltaTime * directionr;

        if (anglel >= 90) //l
        {
            anglel = 90;
            direction = -1;
        }
        else if (anglel <= 0) //l
        {
            anglel = 0;
            direction = 1;
        }

        if (angler <= 270 )
        {
            angler = 270;
            directionr = 1;
        }
        else if (angler >= 360)
        {
            angler = 360;
            directionr = -1;
        }

        if(rotate_anglel > 90f)
        {
            rotate_anglel = 90f;
        }
        if (rotate_anglel < 0)
        {
            rotate_anglel = 0;
        }
        if(rotate_angler > 90f)
        {
            rotate_angler = 90f;
        }
        if(rotate_angler  < 0f)
        {
            rotate_angler = 0f;
        }

        float rl = Mathf.Deg2Rad * (anglel + Offset); //l
        float rr = Mathf.Deg2Rad * (angler); //r;
        left.transform.position = center + new Vector3(Mathf.Cos(rl) * radius, 0, Mathf.Sin(rl) * radius);
        right.transform.position = center + new Vector3(Mathf.Cos(rr) * radius, 0, Mathf.Sin(rr) * radius);
        left.transform.localRotation = Quaternion.Euler(0f, -rotate_anglel + 180f, 0f);
        right.transform.localRotation = Quaternion.Euler(0f, rotate_angler + 180f, 0f);
    }
}

