using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterOnCollision : MonoBehaviour
{
    public GameObject replacement;

    void OnCollisionEnter(Collision col)
    {
        //Spawn cracked version of gameobject and despawn original
        GameObject inst = GameObject.Instantiate(replacement, transform.position + new Vector3(0f,-1.8f,0f), transform.rotation * Quaternion.Euler(90f, 0f, 0f));
        Destroy(gameObject);

        //Despawn instance after 3s
        Destroy(inst, 3f);
    }
}
