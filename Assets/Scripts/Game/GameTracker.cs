using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GameticSDK;

public class GameTracker : MonoBehaviour {

	GameMonitor Monitor { get { return GameMonitor.Instance; } }

	void Awake () {
		Gametic.CustomEvent ("GameStart", new Dictionary<string, object> {
			{ "credits",  PlayerPrefs.GetInt (GameMonitor.CREDITS) }
		});
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
		Gametic.CustomEvent ("GameLevelStarted", new Dictionary<string, object> {
			{ "level", Monitor.lastPlayedLevel },
			{ "credits",  PlayerPrefs.GetInt(GameMonitor.CREDITS) }
		});
	}

	void HandleOnLevelFailed (int levelNumber) {
		Gametic.CustomEvent ("GameLevelFailure", new Dictionary<string, object> {
			{ "level", Monitor.lastPlayedLevel },
			{ "credits",  PlayerPrefs.GetInt (GameMonitor.CREDITS) }
		});
	}

	void HandleOnLevelCompleted (int levelNumber) {
		Gametic.CustomEvent("GameLevelComplete", new Dictionary<string, object> {
			{ "level", Monitor.lastPlayedLevel },
			{ "credits",  PlayerPrefs.GetInt(GameMonitor.CREDITS) }
		});
	}

	void OnAddCredit(int credit, int creditsToAdd){
		Gametic.Purchase ("Cafebazaar", creditsToAdd);
		Gametic.CustomEvent ("AddCredit", new Dictionary<string, object> {
			{ "credits",  credit },
			{ "creditsToAdd",  creditsToAdd }
		});
	}

	void OnSpendCredit(int credit, int creditsToSpend){
		Gametic.CustomEvent ("SpendCredit", new Dictionary<string, object> {
			{ "credits",  credit },
			{ "creditsToSpend",  creditsToSpend }
		});
	}
}
