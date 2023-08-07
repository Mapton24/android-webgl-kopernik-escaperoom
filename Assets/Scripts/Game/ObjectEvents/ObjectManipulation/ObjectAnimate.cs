using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnimate : MonoBehaviour, ICutsceneAction
{
    [SerializeField] private Animator animator;
    [SerializeField] private string animationTrigger;
    public void ExecuteAction()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
