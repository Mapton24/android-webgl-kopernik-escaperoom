using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectVisibilityInCutscene : CutsceneActionBase
{
    [SerializeField] ObjectVisibility objectToChangeVisibility;
    [SerializeField] bool shouldHideObject;
    [SerializeField] bool shouldShowObject;

    protected override void HandleCutsceneStart()
    {
        if (shouldShowObject && !shouldHideObject)
        {
            objectToChangeVisibility.ShowObject();

        }
        if (!shouldShowObject && shouldHideObject)
        {
            objectToChangeVisibility.HideObject();
        }

    }
    protected override void HandleCutsceneEnd()
    {
        if (shouldShowObject && !shouldHideObject)
        {
            objectToChangeVisibility.ShowObject();

        }
        if (!shouldShowObject && shouldHideObject)
        {
            objectToChangeVisibility.HideObject();
        }
    }
}
