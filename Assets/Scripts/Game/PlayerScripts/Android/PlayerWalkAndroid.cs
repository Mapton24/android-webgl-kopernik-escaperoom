using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerWalkAndroid : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float LookDownAngle = 25.0f;
    [SerializeField] private float Speed = 3f;
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private CharacterController cc;

    float minXRotation = -90f;
    float maxXRotation = 90f;
    float currentXRotation = 0f;


    // Update is called once per frame
    void Update()
    {
        TouchMovement();
    }

    private void TouchMovement()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            float rotationX = -touch.deltaPosition.y * rotationSpeed * Time.deltaTime;
            float rotationY = touch.deltaPosition.x * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, rotationY, Space.World);

            currentXRotation += rotationX;
            currentXRotation = Mathf.Clamp(currentXRotation, minXRotation, maxXRotation - LookDownAngle);

            Quaternion xRotation = Quaternion.Euler(currentXRotation, 0f, 0f);
            Quaternion yRotation = Quaternion.Euler(0f, transform.eulerAngles.y, 0f);

            // Quaternion rotation based on X
            Quaternion newRotation = yRotation * xRotation;

            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
