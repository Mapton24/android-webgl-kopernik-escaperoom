using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationInCutscene : CutsceneActionBase
{
    [SerializeField] private Animator animator;
    [SerializeField] private string animationTrigger;

    protected override void HandleCutsceneStart()
    {
        if (shouldWorkOnCutsceneStart && !string.IsNullOrEmpty(animationTrigger))
        {
            animator.SetTrigger(animationTrigger);
            CleanSubscriptions();
        }
    }

    protected override void HandleCutsceneEnd()
    {
        if (shouldWorkOnCutsceneEnd && !string.IsNullOrEmpty(animationTrigger))
        {
            animator.SetTrigger(animationTrigger);
            CleanSubscriptions();
        }
    }
}
