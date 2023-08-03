using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundInCutscene : CutsceneActionBase
{
    [SerializeField] private SoundPlayer player;
    protected override void HandleCutsceneStart()
    {
        if (shouldWorkOnCutsceneStart && player != null)
        {
            player.PlaySound();
        }
    }
    protected override void HandleCutsceneEnd()
    {
        if (shouldWorkOnCutsceneEnd && player != null)
        {
            player.PlaySound();
        }
    }
}
