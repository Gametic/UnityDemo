using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class UIAddCreditsBtnCtrl : MonoBehaviour, IPointerClickHandler {

	GameMonitor Monitor { get { return GameMonitor.Instance; } }

	public int creditsToAdd = 100;

	void Start () {
		GetComponentInChildren<Text>().text = "+ " + creditsToAdd.ToString() + " credits";
	}

	public void OnPointerClick(PointerEventData eventData) {
		int credits = PlayerPrefs.GetInt(GameMonitor.CREDITS) + creditsToAdd;
		PlayerPrefs.SetInt(GameMonitor.CREDITS, credits);
		PlayerPrefs.Save();

		Monitor.AddCredit(credits, creditsToAdd);
	}

}