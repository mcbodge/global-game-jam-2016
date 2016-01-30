using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{

    public GameObject Camera;

    public Vector3 FinalPosition;
    private bool goLeft;
    public float Speed;



    void Update()
    {
        if (goLeft)
        {
            Camera.transform.position = Vector3.Lerp(Camera.transform.position, FinalPosition, Time.deltaTime * Speed);
            if (Vector3.Distance(Camera.transform.position, FinalPosition) < 0.25f)
                goLeft = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!goLeft) {
            FinalPosition = Camera.transform.position;
            FinalPosition.x += 10f;
            ////Camera.transform.position = FinalPosition;
            goLeft = true;
        }
    }

}