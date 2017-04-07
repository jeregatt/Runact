using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text counttext;
	private Rigidbody rb;
	public float threshold;
	private int count;


	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");


		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement *speed);

		if (Input.GetButtonDown("Jump")){
			rb.velocity= new Vector3(0, 8, 0);
		}

		{
			if (transform.position.y < threshold)
				transform.position = new Vector3(0, 0, 0);
		}
	}
		
		void OnTriggerEnter (Collider c) {

			if (c.tag == "Coins") {
				Destroy (c.gameObject);
				count = count +1;
				SetCountText();

			}

	}


	void SetCountText(){
		counttext.text = "Count:" + count.ToString ();
	}
}
