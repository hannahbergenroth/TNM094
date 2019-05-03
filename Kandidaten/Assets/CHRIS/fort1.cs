
using UnityEngine;
using UnityEngine.UI;


public class fort1 : MonoBehaviour {

	float startHealth;
	float health = 100f;
	float damage = 34f;
	// Use this for initialization'

	public Image HealthBar;

	void Start () {
		startHealth = health;
	}

	void Update(){

	}

	void TakeDamage(float amount){

		health -= amount;
		HealthBar.fillAmount = health/startHealth;
		if(health <= 0 )
		{
			Die();
		}

	}

	void Die()
	{
		Destroy(gameObject);
	}

	void OnCollisionEnter(Collision coll){

		if(coll.gameObject.tag == "projectile")
		{
			print("hit fort 1");
			Destroy(coll.gameObject);
			TakeDamage(damage);
		}

	}
}
