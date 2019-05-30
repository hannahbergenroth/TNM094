
using UnityEngine;
using UnityEngine.UI;


public class fort : MonoBehaviour {

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

	public void TakeDamage(float amount){

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

	/*void OnCollisionEnter(Collision coll){

		if(coll.gameObject.tag == "arrow")
		{
			//print("hit fort");
			//Destroy(coll.gameObject);
			TakeDamage(damage);
		}

	}*/
}
