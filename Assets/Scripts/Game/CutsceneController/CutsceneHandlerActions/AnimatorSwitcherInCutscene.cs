using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSwitcherInCutscene : CutsceneActionBase
{
    [SerializeField] private Animator animator;
    [SerializeField] private bool shouldEnableAnimatorOnStart;
    [SerializeField] private bool shouldDisableAnimatorOnStart;
    [SerializeField] private bool shouldEnableAnimatorOnEnd;
    [SerializeField] private bool shouldDisableAnimatorOnEnd;

    protected override void HandleCutsceneStart()
    {
        if (shouldEnableAnimatorOnStart)
        {
            EnableAnimator();
        }
        else if (shouldDisableAnimatorOnStart)
        {
            DisableAnimator();
        }
    }

    protected override void HandleCutsceneEnd()
    {
        if (shouldEnableAnimatorOnEnd && !shouldDisableAnimatorOnEnd)
        {
            EnableAnimator();
        }
        else if (shouldDisableAnimatorOnEnd && !shouldEnableAnimatorOnEnd)
        {
            DisableAnimator();
        }
    }

    public void EnableAnimator()
    {
        if (animator != null)
        {
            animator.enabled = true;
        }
    }

    public void DisableAnimator()
    {
        if (animator != null)
        {
            animator.enabled = false;
        }
    }
}
