using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameticSDK;

public class GenderQuestion : MonoBehaviour {

	public void MaleClicked(){
		PlayerPrefs.SetString ("Gender", "Male");
		Gametic.CustomSegment ("Gender", "Male");
		SceneManager.LoadScene ("MainScene");
	}

	public void FemaleClicked(){
		PlayerPrefs.SetString ("Gender", "Female");
		Gametic.CustomSegment ("Gender", "Female");
		SceneManager.LoadScene ("MainScene");
	}

}
