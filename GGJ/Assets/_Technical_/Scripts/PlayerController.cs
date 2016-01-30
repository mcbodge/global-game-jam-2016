using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float Speed;
    public float JumpSpeed;

    private Rigidbody rb;
    private bool IsGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        IsGrounded = false;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * Speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsGrounded = false;
            rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
        }
    }
}