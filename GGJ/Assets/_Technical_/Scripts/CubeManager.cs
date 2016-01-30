using UnityEngine;
using System.Collections;

public class CubeManager : MonoBehaviour 
{
	public GameObject BlackCube;
	public float timeTakenDuringLerp = 1f;
	public float distanceToMove = 10f;
	private bool _isLerping;
	private Vector3 startPosition;
	private Vector3 endPosition;
	private float timeStartedLerping;

	void Update ()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			StartLerping();
		}	
	}

	void FixedUpdate ()
	{
		if (_isLerping)
		{
			float timeSinceStarted = Time.time - timeStartedLerping;
			float percentageComplete = timeSinceStarted / timeTakenDuringLerp;
			BlackCube.transform.position = Vector3.Lerp(startPosition, endPosition, percentageComplete);

			if (percentageComplete >= 1.0f)
			{
				_isLerping = false;
			}
		}
	}

	void StartLerping ()
	{
		_isLerping = true;
		timeStartedLerping = Time.time;
		startPosition = BlackCube.transform.position;
		endPosition = BlackCube.transform.position - Vector3.up * distanceToMove;
	}
}
