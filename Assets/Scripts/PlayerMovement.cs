using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour {

	public TMP_Text floatingNameText;
	private CharacterController controller;
	private float playerSpeed = 4.0f;

	void Start() {
		controller = GetComponent<CharacterController>();
		floatingNameText.SetText(PlayerPrefs.GetString("Name", "NAME NOT FOUND"));
	}

	void Update() {
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		controller.Move(move * Time.deltaTime * playerSpeed);

		if (move != Vector3.zero) {
			gameObject.transform.forward = move;
		}

		updateFloatingName();
	}

	private void updateFloatingName() {
		floatingNameText.transform.position = new Vector3(controller.transform.position.x, controller.transform.position.y + 0.8f, controller.transform.position.z); ;
	}
}