using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUIGray : MonoBehaviour {

	public Text moneyTextGray;
	// Update is called once per frame
	void Update () {
		moneyTextGray.text = "$" + playerStats.moneyGray.ToString();
	}
}
