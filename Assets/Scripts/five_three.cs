using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class five_three : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;

    public float speed = 50;
    private float alpha1;
    private float alpha2;
   
    void Start()
    {
        Cube2.transform.position = Cube1.transform.position + new Vector3(2, 0, 0);
        Cube2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        float angle = speed * Time.deltaTime;
        float orbit = speed * Time.deltaTime;

        alpha1 = alpha1 + angle;
        alpha2 = alpha2 - angle;

        Cube1.transform.rotation = Quaternion.Euler(0, alpha1, 0);
        Cube2.transform.rotation= Quaternion.Euler(0, alpha2, 0);
        Cube2.transform.RotateAround(Cube1.transform.position, Vector3.up, orbit);
    }
}
