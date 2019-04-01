
using UnityEngine;
using UnityEngine.UI;

public class fort : MonoBehaviour {

	float startHealth;
  public float health = 100f;
	float damage = 34f;
	public Image HealthBar;

	void Start () {

		startHealth = health;
	}

	void Update(){

	}

	public void TakeDamage(float amount){


		health -= amount;
		HealthBar.fillAmount = health/startHealth;
			print(health);
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

		if(coll.gameObject.tag == "projectile1")
		{
			print("hit fort");
			Destroy(coll.gameObject);
			TakeDamage(damage);
		}

	}
}
