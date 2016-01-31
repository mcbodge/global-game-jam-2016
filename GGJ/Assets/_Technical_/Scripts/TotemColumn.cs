using UnityEngine;
using System.Collections;

public class TotemColumn : MonoBehaviour {

    public float timeTakenDuringLerp = 1f;
    public float distanceToMove = 10f;
    public bool _isLerping;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private float timeStartedLerping;

    void FixedUpdate()
    {
        if (_isLerping)
        {
            float timeSinceStarted = Time.time - timeStartedLerping;
            float percentageComplete = timeSinceStarted / timeTakenDuringLerp;
            //HalfTotemDown.transform.position = Vector3.Lerp(startPosition, endPosition, percentageComplete);
            this.transform.position = Vector3.Lerp(startPosition, endPosition, percentageComplete);
            if (percentageComplete >= 1.0f)
            {
                _isLerping = false;
            }
        }
    }

    public void StartLerping()
    {

        _isLerping = true;
        timeStartedLerping = Time.time;
        //startPosition = HalfTotemDown.transform.position;
        //endPosition = HalfTotemDown.transform.position - Vector3.up * distanceToMove;

        startPosition = this.transform.position;
        endPosition = this.transform.position - Vector3.up * distanceToMove;
    }
}
