using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour {
	
	public List<Item> inventory = new List<Item>(12);

	private int gold = 0;
	private GameObject itemToPickup;

	public HUDHandler hudHandler;

	void Update() {
		if (Input.GetKeyDown(KeyCode.F) && itemToPickup != null) {
			addGold(1);
			hudHandler.closeMessagePanel();
			itemToPickup.GetComponent<ItemHandler>().onPickup();
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

	private void addGold(int amount) {
		gold += amount;
		hudHandler.updateGoldText("Gold: " + gold.ToString());
	}
}