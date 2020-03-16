using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	private Rigidbody2D rb2d;
	public float Speed;

	// Use this for initialization
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update()
	{

	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.velocity = movement * Speed;
	}

    
}
