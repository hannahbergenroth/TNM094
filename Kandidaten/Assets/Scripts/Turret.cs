using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Turret : MonoBehaviour {

	private Transform target;

	[Header("Attributes")]
	public float range = 15f;
	public float fireRate = 1f;
	private float fireCountDown = 0f;

	[Header("Unity Setup fields")]
	public Transform partToRotate;
	private string enemyTag = "Enemy";
	public float turnSpeed = 10f;

	public GameObject bulletPrefab;
	public Transform firePoint;

	void Start () {
		InvokeRepeating("UpdateTarget", 0f, 0.5f);
		//dragging
	}


	// Update is called once per frame
	void Update () {
		if(target == null)
		{
			return;
		}

		//target to lock on
		Vector3 dir = target.position - transform.position;
		Quaternion lookRotation = Quaternion.LookRotation(dir);
		Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
		partToRotate.rotation = Quaternion.Euler(0f, rotation.y, -90f);

		if(fireCountDown <= 0f)
		{
			Shoot();
			fireCountDown = 1f/fireRate;
		}
		fireCountDown -= Time.deltaTime;

	}

	void Shoot(){
		GameObject bulletGO = Instantiate(bulletPrefab, firePoint.position, partToRotate.rotation) as GameObject;
		Bullet bullet = bulletGO.GetComponent<Bullet>();

		if(bullet != null)
		{
			bullet.Seek(target);
		}
	}

	void UpdateTarget(){
		GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
		float shortestDistance = Mathf.Infinity;
		GameObject nearestEnemy = null;

		foreach (GameObject enemy in enemies)
		{
			float distToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
			if(distToEnemy > 0f && distToEnemy < shortestDistance) //first comparison wont be needed when introducing team for towers
			{
				shortestDistance = distToEnemy;
				nearestEnemy = enemy;
			}
		}

		if(nearestEnemy != null && shortestDistance <= range)
		{
			target = nearestEnemy.transform;
		}
		else target = null;
	}

	void OnDrawGizmosSelected(){
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, range);
	}
}
