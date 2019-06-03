
using UnityEngine;
using UnityEngine.UI;


public class fort1 : MonoBehaviour {

	public GameObject replacement;
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
		if(health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
        //Spawn cracked version of gameobject and despawn original
        Destroy(gameObject);
        GameObject inst = GameObject.Instantiate(replacement, transform.position + new Vector3(0f,-0f,0f), transform.rotation * Quaternion.Euler(0f, 0f, 0f));

        //Despawn cracked version after 3s
        Destroy(inst, 3f);
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
