using UnityEngine;
using System.Collections;

public class RelativePosition : MonoBehaviour{
	
private GameObject leftSide;
private GameObject rightSide;
private GameObject floor;
private GameObject roof;

private float deltaXRelative;
private float deltaYRelative;
 

	float Delta(GameObject leftSide, GameObject rightSide, GameObject floor, GameObject roof, int axis) {
        float deltaX = leftSide.transform.position.x - transform.position.x;
		deltaXRelative = deltaX / (leftSide.transform.position.x - rightSide.transform.position.x);
		
        float deltaY = leftSide.transform.position.y - transform.position.y;
		deltaYRelative = deltaX / (roof.transform.position.y - floor.transform.position.y);
		
		
		if (axis.Equals(0)) return deltaX;
		else return deltaY;
	}

    void Start()
    {
		leftSide = GameObject.Find("BorderLeft");
		rightSide = GameObject.Find("BorderRight");
		floor = GameObject.Find("Floor");
		roof = GameObject.Find("Roof");
    }
    void FixedUpdate()
	{
		deltaXRelative = Delta(leftSide, rightSide, floor, roof, 0);		
		deltaYRelative = Delta(leftSide, rightSide, floor, roof, 1);		
    }
}	