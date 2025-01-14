using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody ballRigidBody;
    [SerializeField] private Collider ballCollider;
    [SerializeField] private float rollSpeed = 2f;
    [SerializeField] private float jumpForce = 20f;
    private float distToGround;

    void Start(){
        distToGround = ballCollider.bounds.extents.y;
    }

    private bool isGrounded(){
        return Physics.Raycast(transform.position, Vector3.down, distToGround + 0.1f);
    }

    public void moveBall(Vector3 input){
        Vector3 inputForce = new Vector3(input.x * rollSpeed, isGrounded() ? input.y * jumpForce : 0, input.z * rollSpeed);
        ballRigidBody.AddForce(inputForce);
    }
}
