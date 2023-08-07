using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectVisibilityInCutscene : CutsceneActionBase
{
    [SerializeField] ObjectVisibility objectToChangeVisibility;

    protected override void HandleCutsceneStart()
    {
        objectToChangeVisibility.ChangeObjectVisibility();
    }
    protected override void HandleCutsceneEnd()
    {
        objectToChangeVisibility.ChangeObjectVisibility();

    }
}
