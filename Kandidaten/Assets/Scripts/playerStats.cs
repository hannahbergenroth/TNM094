using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour {

	public static int moneyOrange;
	public static int moneyGray;
	public int startMoney = 400;

	void Start(){
		moneyOrange = startMoney;
		moneyGray = startMoney;
	}


}
