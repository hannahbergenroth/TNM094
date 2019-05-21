using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour
{
    //Cracked version of models
    public GameObject replacement;

    public Transform healthBar;
    public Slider healthFill;

    public float currentHealth;
    public float maxHealth;

    // Update is called once per frame
    void Update()
    {
        //PositionHealthBar();
    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        healthFill.value = currentHealth / maxHealth;

        if(currentHealth <= 0)
        {
            Destroyed();
        }
    }

    private void PositionHealthBar()
    {
        Vector3 currentPos = transform.position;
        healthBar.position = currentPos;
    }

    private void Destroyed()
    {
        //Spawn cracked version of gameobject and despawn original
        Destroy(gameObject);
        GameObject inst = GameObject.Instantiate(replacement, transform.position + new Vector3(0f, -0f, 0f), transform.rotation * Quaternion.Euler(0f, 0f, 0f));

        //Despawn cracked version after 3s
        Destroy(inst, 3f);
    }
}
