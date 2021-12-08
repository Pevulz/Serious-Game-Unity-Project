using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    Rigidbody2D rb;

	[SerializeField]
	float accelerationPower = 2f;
	[SerializeField]
	float steeringPower = 2f;
	float steeringAmount, speed, direction;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
        rb.freezeRotation = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		steeringAmount = - Input.GetAxis ("Horizontal");
		speed = Input.GetAxis ("Vertical") * accelerationPower;
		direction = Mathf.Sign(Vector2.Dot (rb.velocity, rb.GetRelativeVector(Vector2.up)));
		rb.rotation += steeringAmount * steeringPower * rb.velocity.magnitude * direction;

		rb.AddRelativeForce (Vector2.up * speed);

		rb.AddRelativeForce ( - Vector2.right * rb.velocity.magnitude * steeringAmount / 2);
			
	}
}
