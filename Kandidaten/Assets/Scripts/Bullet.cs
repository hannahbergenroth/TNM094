using UnityEngine;

public class Bullet : MonoBehaviour {

	private Transform target;
	public float speed = 70f;
	public float explosionRadius = 0f;
	public GameObject impactEffect;
	private float damageAmount;

	public string bulletType;
	public string enemyName = "Enemy";

	void Start(){
		if(bulletType == "arrow"){
			damageAmount = 34f;
		}
		else if (bulletType == "ball"){
			damageAmount = 50f;
		}
	}


	public void Seek(Transform _target){
		target = _target;


	}

	// Update is called once per frame
	void Update () {
		if(target == null){
			Destroy(gameObject);
			return;
		}

		Vector3 dir = target.position - transform.position;
		float distanceThisFrame = speed * Time.deltaTime;

		if(dir.magnitude <= distanceThisFrame)
		{
			HitTarget();
			return;
		}
		transform.Translate(dir.normalized * distanceThisFrame, Space.World);
		transform.LookAt(target);

	}

	void HitTarget()
	{
		GameObject effectIns = (GameObject) Instantiate(impactEffect,transform.position,transform.rotation);
		Destroy(effectIns, 2f);
		if(explosionRadius > 0f){
			Explode();
		}else{
			Damage(target);
		}
		Destroy(gameObject);
	}

	void Explode()
	{
		Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
		foreach (Collider collider in colliders)
		{
			if(collider.tag == enemyName)
			{
				Damage(collider.transform);
			}
		}
	}

	void Damage(Transform enemy){
        enemy.gameObject.GetComponent<fort>().TakeDamage(damageAmount);
	}

	void OnDrawGizmosSelected(){
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, explosionRadius);
	}

}
