using System.Collections;
using UnityEngine;

public class StopSoundInCutscene : CutsceneActionBase
{
    [SerializeField] private SoundStopper stopper;
    protected override void HandleCutsceneStart()
    {
        if (shouldWorkOnCutsceneStart && stopper != null)
        {
            stopper.StopSound();
        }
    }
    protected override void HandleCutsceneEnd()
    {
        if (shouldWorkOnCutsceneEnd && stopper != null)
        {
            stopper.StopSound();
        }
    }
}
