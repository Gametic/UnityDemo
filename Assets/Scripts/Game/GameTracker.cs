using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameTracker : MonoBehaviour {

	GameMonitor Monitor { get { return GameMonitor.Instance; } }

	void Awake () {

	}

	void Start () {
		AssignDelegates();
	}

	void AssignDelegates() {
		Monitor.OnLevelCompleted += HandleOnLevelCompleted;
		Monitor.OnLevelFailed += HandleOnLevelFailed;
		Monitor.OnLevelStarted += HandleOnLevelStarted;
		Monitor.OnAddCredit += OnAddCredit;
		Monitor.OnSpendCredit += OnSpendCredit;
	}

	void HandleOnLevelStarted (int levelNumber) {
		
	}

	void HandleOnLevelFailed (int levelNumber) {

	}

	void HandleOnLevelCompleted (int levelNumber) {

	}

	void OnAddCredit(int credit, int creditsToAdd){

	}

	void OnSpendCredit(int credit, int creditsToSpend){

	}
}
