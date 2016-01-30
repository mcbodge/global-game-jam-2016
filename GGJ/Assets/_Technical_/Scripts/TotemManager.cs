using UnityEngine;
using System.Collections;

public class TotemManager : MonoBehaviour 
{
	private Animator animator;
	//public GameObject HalfTotemDown;
	public float timeTakenDuringLerp = 1f;
	public float distanceToMove = 10f;
	private bool _isLerping;
	private Vector3 startPosition;
	private Vector3 endPosition;
	private float timeStartedLerping;

	void Awake() {
		animator = GetComponent<Animator>();
	}	
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			StartLerping();
		} else if(Input.GetKey(KeyCode.R)) animator.SetTrigger("StartRotation");
		
	}

	void FixedUpdate ()
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

	void StartLerping ()
	{
        
		_isLerping = true;
		timeStartedLerping = Time.time;
		//startPosition = HalfTotemDown.transform.position;
		//endPosition = HalfTotemDown.transform.position - Vector3.up * distanceToMove;
		
		startPosition = this.transform.position;
		endPosition = this.transform.position - Vector3.up * distanceToMove;
	}
}
