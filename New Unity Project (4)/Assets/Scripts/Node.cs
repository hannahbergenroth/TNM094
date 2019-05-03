using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

	public Color hoverColor;
	private Renderer rend;
	private Color startColor;
	private GameObject objectOnNode = null;

	void Start(){
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
	}

	void OnMouseDown(){
		if(objectOnNode != null){
			print("cant build here");
			return;
		}

		//build turret
	}

	void OnMouseEnter(){
		rend.material.color = hoverColor;
	}

	void OnMouseExit(){
		rend.material.color = startColor;
	}

}
