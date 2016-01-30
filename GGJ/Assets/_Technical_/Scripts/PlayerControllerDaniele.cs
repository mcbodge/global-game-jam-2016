using UnityEngine;
using System.Collections;
using UnityEditor.Animations;


public class PlayerControllerDaniele : MonoBehaviour
{

    public float Speed;
    public float JumpSpeed;

    private Rigidbody rb;
    private bool IsGrounded;
	public Animation idle;
	public Animation run;
	public AnimatorController myController;
		

    void Start()
    {
        rb = GetComponent<Rigidbody>();
		rb.freezeRotation = true;
        IsGrounded = false;	
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveHorizontal, 1.0f, moveVertical);
		//print(moveHorizontal);
        rb.AddForce(movement * Speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
			IsGrounded = false;
            rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
        }
		if (Input.GetKeyDown(KeyCode.D))
        {
			rb.AddForce(movement * Speed);
        }
		if (Input.GetKeyDown(KeyCode.A))
        {
			rb.AddForce(movement * Speed);
			//GetComponent<Animation>().Play("idle");
			//print(GetComponent<Animation>().Play());
        }		
                /*if (Input.GetKeyDown(KeyCode.A))
                 {
                         Vector3 position = this.transform.position;
                         position.x--;
                         this.transform.position = position;
                 }
                 if (Input.GetKeyDown(KeyCode.D))
                 {
                         Vector3 position = this.transform.position;
                         position.x++;
                         this.transform.position = position;
                 }
                 if (Input.GetKeyDown(KeyCode.W))
                 {
                         Vector3 position = this.transform.position;
                         position.y++;
                         this.transform.position = position;
                 }
                 if (Input.GetKeyDown(KeyCode.S))
                 {
                         Vector3 position = this.transform.position;
                         position.y--;
                         this.transform.position = position;
                 }		*/
    }
}



