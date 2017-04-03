using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");


		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);

		rb.AddForce (movement *speed);

		if (Input.GetButtonDown("Jump")){
			rb.velocity= new Vector3(0, 8, 0);
		}
	}
		
		void OnTriggerEnter2D (Collider2D c) {

			if (c.tag == "Coins") {
				Destroy (c.gameObject);
			}

	}
}
