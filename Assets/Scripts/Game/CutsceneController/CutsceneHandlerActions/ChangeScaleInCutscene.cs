using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeScaleInCutscene : CutsceneActionBase
{
    [SerializeField] private ObjectChangeScale objectToChange;
    protected override void HandleCutsceneStart()
    {
        objectToChange.ChangeScale();
    }
    protected override void HandleCutsceneEnd()
    {
        objectToChange.ChangeScale();
    }
}
