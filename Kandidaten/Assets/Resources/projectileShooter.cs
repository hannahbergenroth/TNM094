using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class projectileShooter : MonoBehaviour
{
    Rigidbody rb;
    GameObject prefab, projectile;
    Vector3 startPos, endPos, direction;
    public float shootPower = 0.001f;


    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
            startPos.z = 14.5f;
            projectile = Instantiate(prefab, Camera.main.ScreenToWorldPoint(startPos), Quaternion.identity) as GameObject;
            rb = projectile.GetComponent<Rigidbody>();
        }
    }

    void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            endPos.z = 17f;
            direction = startPos - endPos;
            rb.AddForce(direction * shootPower);
            rb.AddForce(Vector3.forward * 10f);
        }
    }

}
