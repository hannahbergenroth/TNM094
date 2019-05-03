using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class spawnEnemy : MonoBehaviour {

	Rigidbody rb;
	GameObject projectile;
	Vector3 startPos, endPos, direction;
	float shootPower = 12f;
	public GameObject prefab;

	void OnMouseDown()
	{
		if(EventSystem.current.IsPointerOverGameObject())
		return ;

			if (Input.GetMouseButtonDown(0))
			{
					startPos = Input.mousePosition;
					startPos.z = 5f;
					projectile = Instantiate(prefab, Camera.main.ScreenToWorldPoint(startPos), Quaternion.identity) as GameObject;
					rb = projectile.GetComponent<Rigidbody>();
			}
	}

	void OnMouseUp()
	{
			if (Input.GetMouseButtonUp(0))
			{
					endPos = Input.mousePosition;
					endPos.z = 5f;
					direction = startPos - endPos;
					rb.AddForce(direction * shootPower);
			}
	}
}
