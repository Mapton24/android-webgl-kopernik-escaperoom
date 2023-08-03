using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVisibility : MonoBehaviour
{
    [SerializeField] private GameObject objectToToggle;

    public void HideObject()
    {
        if (objectToToggle != null)
        {
            objectToToggle.SetActive(false);
        }
    }

    public void ShowObject()
    {
        if (objectToToggle != null)
        {
            objectToToggle.SetActive(true);
        }
    }
}
