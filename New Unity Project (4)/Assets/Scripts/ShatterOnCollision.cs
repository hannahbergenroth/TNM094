using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterOnCollision : MonoBehaviour
{
    //Cracked version of models
    public GameObject replacement;

    void OnCollisionEnter(Collision col)
    {
        //Spawn cracked version of gameobject and despawn original
        Destroy(gameObject);
        GameObject inst = GameObject.Instantiate(replacement, transform.position + new Vector3(0f,-1.8f,0f), transform.rotation * Quaternion.Euler(90f, 0f, 0f));

        //Despawn cracked version after 3s
        Destroy(inst, 3f);
    }
}

