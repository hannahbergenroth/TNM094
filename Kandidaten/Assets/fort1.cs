
using UnityEngine;
using UnityEngine.UI;


public class fort1 : MonoBehaviour {

	public float startHealth;
	public float health = 100f;
	public float damage = 34f;
	// Use this for initialization'

	public Image HealthBar;

	void Start () {
		startHealth = health;
	}

	void Update(){

	}

 	public void TakeDamage1(float amount){

		health -= amount;
		print(health);
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
			TakeDamage1(damage);
		}

	}
}
