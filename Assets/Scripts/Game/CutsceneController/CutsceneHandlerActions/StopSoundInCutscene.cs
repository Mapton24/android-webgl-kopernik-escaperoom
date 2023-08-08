using System.Collections;
using UnityEngine;

public class StopSoundInCutscene : CutsceneActionBase
{
    [SerializeField] private SoundStopper stopper;
    protected override void HandleCutsceneStart()
    {
        if (shouldWorkOnCutsceneStart && stopper != null)
        {
            stopper.ExecuteAction();
        }
    }
    protected override void HandleCutsceneEnd()
    {
        if (shouldWorkOnCutsceneEnd && stopper != null)
        {
            stopper.ExecuteAction();
        }
    }
}
