using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 FirstPosition;
    public Vector3 LastPosition;
    public Transform parent;
    public float ObjectSpeed = 1.0f;

    //private Renderer _myRenderer;

    public GameObject StartingLight;
    public GameObject GazingLight;
    private GameObject _startingLight;
    private GameObject _gazingLight;

    bool _isInFirstPosition = true;
    bool activateMovement = false;

    void Awake()
    {
        InitializeLight();
        transform.position = FirstPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (activateMovement)
        {
            MoveObjectToPositions();
        }
    }

    void InitializeLight()
    {
        _startingLight = Instantiate(StartingLight, new Vector3(0,3,0), Quaternion.identity, parent);
        _gazingLight = Instantiate(GazingLight, new Vector3(0, 3, 0), Quaternion.identity, parent);
        _gazingLight.SetActive(false);

    }
    private void ChangeLight(bool gazedAt)
    {
        if (StartingLight != null && GazingLight != null)
        {
            if (gazedAt)
            {
                _startingLight.SetActive(false);
                _gazingLight.SetActive(true);
            }
            else
            {
                _gazingLight.SetActive(false);
                _startingLight.SetActive(true);
            }
        }
    }

    private void MoveObjectToPositions()
    {
        if (_isInFirstPosition)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, LastPosition, Time.deltaTime * ObjectSpeed);
            if (gameObject.transform.position == LastPosition)
            {
                _isInFirstPosition = false;
                activateMovement = false;
            }
        } else if (!_isInFirstPosition) {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, FirstPosition, Time.deltaTime * ObjectSpeed);
            if (gameObject.transform.position == FirstPosition)
            {
                _isInFirstPosition = true;
                activateMovement = false;
            }
        }
    }

    public void OnPointerEnter()
    {
        ChangeLight(true);
    }
    public void OnPointerExit()
    {
        ChangeLight(false);
    }

    public void OnPointerClick()
    {
        activateMovement = true;
    }
}
