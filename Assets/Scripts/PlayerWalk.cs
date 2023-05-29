using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{

    public Transform vrPlayer;

    public float LookDownAngle = 25.0f;
    public float Speed = 3.0f;
    public bool MoveForward;
    private CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vrPlayer.eulerAngles.x >= LookDownAngle && vrPlayer.eulerAngles.x < 90.0f)
        {
            MoveForward = true;
        } else
        {
            MoveForward = false;
        }

        if (MoveForward == true)
        {
            Vector3 forward = vrPlayer.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * Speed);
        }
    }
}
