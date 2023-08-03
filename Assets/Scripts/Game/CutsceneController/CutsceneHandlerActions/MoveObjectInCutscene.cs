using UnityEngine;

public class MoveObjectInCutscene : CutsceneActionBase
{
    [SerializeField] private Transform objectToMove;
    [SerializeField] private Transform targetPosition;
    [SerializeField] private float movementDuration = 1f;


    private Vector3 initialPosition;
    private float timer;

    protected override void Start()
    {
        base.Start();
        initialPosition = objectToMove.position;
    }
    protected override void HandleCutsceneStart()
    {
        _ = shouldWorkOnCutsceneStart ? StartCoroutine(MoveToTargetPosition()) : null;
    }
    protected override void HandleCutsceneEnd()
    {
        _ = shouldWorkOnCutsceneEnd ? StartCoroutine(MoveToTargetPosition()) : null;
    }

    private System.Collections.IEnumerator MoveToTargetPosition()
    {
        timer = 0f;
        while (timer < movementDuration)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / movementDuration);
            objectToMove.position = Vector3.Lerp(initialPosition, targetPosition.position, t);
            yield return null;
        }

        objectToMove.position = targetPosition.position;
        OnDestroy();
    }
}
