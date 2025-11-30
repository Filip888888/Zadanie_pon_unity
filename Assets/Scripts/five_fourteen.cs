using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;

public class five_fourteen : MonoBehaviour
{

    public float speed = 100f;
    float maxAngle = 45f;
    private float currentAngle = 0;
    private int direction = -1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        currentAngle += direction * speed * Time.deltaTime;

        if (currentAngle >= maxAngle)
        {
            currentAngle = maxAngle;
            direction = -1;
        }
        else if (currentAngle <= -maxAngle)
        {
            currentAngle = -maxAngle;
            direction = 1;
        }
        transform.localRotation = Quaternion.Euler(currentAngle - 90, -180f, 90f);
    }
}
