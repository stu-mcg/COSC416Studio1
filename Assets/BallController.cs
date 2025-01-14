using System;
using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField] private Rigidbody ballRigidBody;
    [SerializeField] private float ballSpeed = 2f;

    public void moveBall(Vector2 input){
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        ballRigidBody.AddForce(inputXZPlane * ballSpeed);
    }
}
