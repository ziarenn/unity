using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Character_Controller controller;
	public Animator animator;
	public float l_runSpeed = 50f;
	public float r_runSpeed = 30f;
	float horizontalMove = 0f;
	bool jump = false;

	void Update()
	{
		float horizontalInput = Input.GetAxisRaw("Horizontal");
		if (horizontalInput < 0f) // moving left
		{
			horizontalMove = horizontalInput * l_runSpeed;
		}
		else
		{
			horizontalMove = horizontalInput * r_runSpeed;
		}
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}

	}

	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate()
	{
		if (controller != null)
		{
			controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		}
		jump = false;
	}

}
