using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockwaveInCutscene : CutsceneActionBase
{
    [SerializeField] private Shockwave shockwave;

    protected override void HandleCutsceneStart()
    {
        shockwave.ApplyShockwave();
    }
    protected override void HandleCutsceneEnd()
    {
        shockwave.ApplyShockwave();
    }
}
