using UnityEngine;
using System.Collections;


public class AnimatorController : MonoBehaviour {

    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}

    public void Run()
    {
        animator.SetBool("Run", true);
		animator.Play("run");
    }
    void FixedUpdate()
    {

		animator.Play("idle",-1,0f);
        animator.SetBool("Run", true);
		
	if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetBool("Run", true);
            }	
		
    }	
}