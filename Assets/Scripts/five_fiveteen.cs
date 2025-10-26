using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;

public class five_fiveteen: MonoBehaviour
{

    public GameObject left;
    public GameObject right;
    public float speed = 20f;
    private float angle_left = 0f;
    private float angle_right = 0f;
    private float maxAngle = 90f;
    private float minAngle = 0f;
    private int directionLeft = 1;
    private int directionRight = -1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        left.transform.position = new Vector3(8f, 2.83f, 13.77f);
        right.transform.position = new Vector3(19f, 2.83f, 13.77f);
    }

    // Update is called once per frame
    void Update()
    {
        angle_left += directionLeft * speed * Time.deltaTime;
        angle_right += directionRight * speed + Time.deltaTime;
        //prawa
        if(angle_right <= minAngle)
        {
            angle_right = minAngle;
            directionLeft = 1;
        }
        else if(angle_right >= maxAngle)
        {
            angle_right = maxAngle;
            directionLeft = -1;
        }
        //lewa
        if (angle_left <= minAngle)
        {
            angle_left = minAngle;
            directionRight = -1;
        }
        else if (angle_left >= -maxAngle)
        {
            angle_left = -maxAngle;
            directionRight = 1;
        }
        left.transform.localRotation = Quaternion.Euler(0f, angle_left, 0f);
        right.transform.localRotation = Quaternion.Euler(0f, angle_right, 0f);
    }
}
