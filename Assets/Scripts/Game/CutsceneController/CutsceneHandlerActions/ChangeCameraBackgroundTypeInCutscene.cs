using System;
using UnityEngine;

public class ChangeCameraBackgroundTypeInCutscene : CutsceneActionBase
{
    [SerializeField] private Camera cameraToChange;
    protected override void HandleCutsceneEnd()
    {
      //  _ = shouldWorkOnCutsceneStart ? (Action) (() => ChangeSkyBox()) : null;
        if (shouldWorkOnCutsceneStart)
        {
            ChangeSkyBox();
        }
    }

    private void ChangeSkyBox()
    {
        if (cameraToChange != null)
        {
            cameraToChange.clearFlags = CameraClearFlags.Skybox;
        }
    }
}
