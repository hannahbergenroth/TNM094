using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.tag == "projectile" || coll.gameObject.tag == "projectile1")
		{
			Destroy(coll.gameObject);
		}
	}
}
