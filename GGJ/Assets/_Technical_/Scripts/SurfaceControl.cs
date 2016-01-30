using UnityEngine;
using System.Collections;

public class SurfaceControl : MonoBehaviour
{

	void OnCollisionStay()
    {
        PlayerController.Instance.IsGrounded = true;
    }
}
