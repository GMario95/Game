using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour {

	public TMP_Text floatingNameText;
	private CharacterController controller;
	private float playerSpeed = 4.0f;
	private float jumpSpeed = 3.5f;
	private float gravity = 9.81f;
	private float yDirection;
	private bool hasDoubleJump = false;

	void Start() {
		controller = GetComponent<CharacterController>();
		floatingNameText.SetText(PlayerPrefs.GetString("Name", "NAME NOT FOUND"));
	}

	void Update() {
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

		bool isJumping = Input.GetButtonDown("Jump");

		if (controller.isGrounded) {
			hasDoubleJump = true;
			if (isJumping) {
				yDirection = jumpSpeed;
			}
		} else if (isJumping && hasDoubleJump) {
			yDirection = jumpSpeed;
			hasDoubleJump = false;
		}

		yDirection -= gravity * Time.deltaTime;
		move.y = yDirection;

		controller.Move(move * Time.deltaTime * playerSpeed);

		if (transform.position.y < -50) {
			transform.position = new Vector3(0f, 5f, 0f);
		}

		updateFloatingName();
	}

	private void updateFloatingName() {
		floatingNameText.transform.position = new Vector3(controller.transform.position.x, controller.transform.position.y + 0.8f, controller.transform.position.z); ;
	}
}