using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Point_of_View : MonoBehaviour
{
    public Transform player; // przypisz gracza w Inspectorze
    public Vector3 offset = new Vector3(0f, 2f, -5f); // odleg�o�� kamery od gracza
    public float smoothSpeed = 5f; // p�ynno�� ruchu kamery

    void LateUpdate()
    {
        // celna pozycja kamery wzgl�dem gracza
        Vector3 desiredPosition = player.position + offset;
        // p�ynne przej�cie
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // opcjonalnie: kamera patrzy na gracza
        transform.LookAt(player);
    }
}
