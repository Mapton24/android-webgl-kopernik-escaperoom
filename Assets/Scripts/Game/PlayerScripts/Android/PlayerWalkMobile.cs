using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerWalkMobile : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float LookDownAngle = 25.0f;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float gravity = 9.81f;
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private CharacterController cc;

    bool moveForward = false;
    bool moveBackward = false;
    bool strafeLeft = false;
    bool strafeRight = false;


    float minXRotation = -90f;
    float maxXRotation = 90f;
    float currentXRotation = 0f;


    // Update is called once per frame
    void Update()
    {
        TouchRotation();
        CalculateGravity();
        CalculateMovement();
    }
    private void CalculateGravity()
    {
        Vector3 gravityVector = Vector3.down * gravity * Time.deltaTime;
        cc.Move(gravityVector);
    }
    private void CalculateMovement()
    {
        Vector3 moveDirection = Vector3.zero;

        if (moveForward) moveDirection += transform.forward;
        if (moveBackward) moveDirection -= transform.forward;
        if (strafeLeft) moveDirection -= transform.right;
        if (strafeRight) moveDirection += transform.right;

        moveDirection.Normalize();
        moveDirection *= speed * Time.deltaTime;

        // Move the character controller
        cc.Move(moveDirection);

    }
    public void MoveForward(bool movePlayer)
    {
        moveForward = movePlayer;
    }

    public void MoveBackward(bool movePlayer)
    {
        moveBackward = movePlayer;
    }

    public void StrafeLeft(bool movePlayer)
    {
        strafeLeft = movePlayer;
    }

    public void StrafeRight(bool movePlayer)
    {
        strafeRight = movePlayer;
    }

    private void TouchRotation()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            //if (!EventSystem.current.IsPointerOverGameObject(touch.fingerId))
            //{

                float rotationX = -touch.deltaPosition.y * rotationSpeed * Time.deltaTime;
                float rotationY = touch.deltaPosition.x * rotationSpeed * Time.deltaTime;

                transform.Rotate(Vector3.up, rotationY, Space.World);

                currentXRotation += rotationX;

                Quaternion xRotation = Quaternion.Euler(currentXRotation, 0f, 0f);
                Quaternion yRotation = Quaternion.Euler(0f, transform.eulerAngles.y, 0f);

                // Quaternion rotation based on X
                Quaternion newRotation = yRotation * xRotation;

                transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
            //}
        }
    }
}
