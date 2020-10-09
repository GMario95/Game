using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Onboarding : MonoBehaviour
{
	public InputField nameInput;

    public void PlayGame () {
		string characterName = nameInput.text;
		PlayerPrefs.SetString("Name", characterName);

		//TODO:(Mario) Get class from toggle group, store in player prefs

		//TODO:(Mario) Hook up point buy sliders with text UI. Need some type of manager to handle pointsLeft and getting slider values

		//TODO:(Mario) Design player object for serialization, sort out a serializer/deserializer

		SceneManager.LoadScene(1);
		SceneManager.UnloadSceneAsync(0);
	}
}
