using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

	public int timeout;

	void Start () {
		StartCoroutine (NextScene());
	}

	IEnumerator NextScene(){
		yield return new WaitForSeconds (timeout);
		if (PlayerPrefs.HasKey ("Gender")) {
			SceneManager.LoadScene ("MainScene");
		} else {
			SceneManager.LoadScene ("GenderQuestion");
		}
	}

}
