using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    public float Speed;
    public float JumpSpeed;

    private Rigidbody rb;
    public bool IsGrounded;

    private int myVar;
    private float gravityRatioAdjuster = 48.0f;

    public bool ReadInput = true;


    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void StopPlayer(float seconds)
    {
        ReadInput = false;
        Invoke("StartPlayer", seconds);
    }

    private void StartPlayer()
    {
        ReadInput = true;
    }

    void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * rb.mass * gravityRatioAdjuster);
        if (ReadInput)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

			
			rb.AddForce(movement * Speed);
			

            if (Input.GetKeyDown(KeyCode.W) && IsGrounded)
            {
                IsGrounded = false;
                rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
            }
        }
    }
}