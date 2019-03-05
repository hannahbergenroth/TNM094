using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileShooter : MonoBehaviour
{
    GameObject prefab;
    Vector3 startPos, endPos, direction;
    public float shootPower = 0.001f;

    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;
    }

    // Update is called once per frame

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
            startPos.z = 10;
        }
    }

    void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            endPos.z = 10;
            direction = startPos - endPos;

            GameObject projectile = Instantiate(prefab, Camera.main.ScreenToWorldPoint(startPos), Quaternion.identity) as GameObject;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.AddForce(direction * shootPower);
        }
    }
}
