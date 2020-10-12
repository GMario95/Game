using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour {
	
	public List<Item> inventory = new List<Item>(12);
	
	private GameObject itemToPickup;

	public HUDHandler hudHandler;

	void Update() {
		if (Input.GetKeyDown(KeyCode.F) && itemToPickup != null) {
			hudHandler.closeMessagePanel();
			itemToPickup.GetComponent<ItemHandler>().onPickup();
		}

		if (Input.GetKeyDown(KeyCode.I)) {
			hudHandler.toggleInventoryPanel();
		}

		if (Input.GetKeyDown(KeyCode.C)) {
			hudHandler.toggleCharacterPanel();
		}
	}

	private void OnTriggerEnter(Collider other) {
		if (other.GetComponent("ItemHandler") != null) {
			itemToPickup = other.gameObject;
			hudHandler.openMessagePanel("Gold (1)");
		}
	}

	private void OnTriggerExit(Collider other) {
		if (other.GetComponent("ItemHandler") != null) {
			itemToPickup = null;
			hudHandler.closeMessagePanel();
		}
	}
}