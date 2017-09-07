using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenderQuestion : MonoBehaviour {

	public void MaleClicked(){
		PlayerPrefs.SetString ("Gender", "Male");

		SceneManager.LoadScene ("MainScene");
	}

	public void FemaleClicked(){
		PlayerPrefs.SetString ("Gender", "Female");

		SceneManager.LoadScene ("MainScene");
	}

}
