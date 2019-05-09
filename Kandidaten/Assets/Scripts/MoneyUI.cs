using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour {

	public Text moneyTextOrange;
	// Update is called once per frame
	void Update () {
		moneyTextOrange.text = "$" + playerStats.moneyOrange.ToString();
	}
}
