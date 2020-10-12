using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDHandler : MonoBehaviour
{
	public GameObject characterPanel;
	public GameObject inventoryPanel;
	public GameObject messagePanel;

	public void toggleInventoryPanel() {
		inventoryPanel.SetActive(!inventoryPanel.active);
	}

	public void toggleCharacterPanel() {
		characterPanel.SetActive(!characterPanel.active);
	}

	public void openMessagePanel(string text) { 
		messagePanel.SetActive(true);
	}

	public void closeMessagePanel() {
		messagePanel.SetActive(false);
	}
}
