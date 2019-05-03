using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class multiTouch : MonoBehaviour {

	public Text tCount;

	// Update is called once per frame
	void Update () {

		tCount.text = Input.touchCount.ToString();
	}
}
