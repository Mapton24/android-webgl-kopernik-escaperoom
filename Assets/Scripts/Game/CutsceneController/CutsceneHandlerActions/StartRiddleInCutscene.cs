using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRiddleInCutscene : CutsceneActionBase
{
    [SerializeField] SolarRiddle solarRiddle;
    [SerializeField] CutsceneSequencer winSequencer;
    private bool hasInitializedWinCutscene = false;
    private void Update()
    {
        if(solarRiddle.RiddleSolved() && !hasInitializedWinCutscene)
        {
            winSequencer.StartNextCutscene();
            hasInitializedWinCutscene = true;
            OnDestroy();
        }
    }

    protected override void HandleCutsceneStart()
    {
        solarRiddle.StartRiddle();
        HandleEventStarting();
    }
}
