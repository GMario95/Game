using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDHandler : MonoBehaviour
{
	public Text goldText;
	public GameObject messagePanel;

	public void openMessagePanel(string text) { 
		messagePanel.SetActive(true);
	}

	public void closeMessagePanel() {
		messagePanel.SetActive(false);
	}

	public void updateGoldText(string amount) {
		goldText.text = amount;
	}
}
