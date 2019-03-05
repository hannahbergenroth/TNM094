using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    Vector2 startPos, endPos, direction;
    Rigidbody myRigidbody;
    public float shootPower = 10f;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
    }

    void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            direction = startPos - endPos;
            myRigidbody.isKinematic = false;
            myRigidbody.AddForce(direction * shootPower);
            Instantiate(myRigidbody);
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        // how much the character should be knocked back
        float magnitude = 500f;
        // calculate force vector
        Vector3 force = transform.position - other.transform.position;
        // normalize force vector to get direction only and trim magnitude
        force.Normalize();
        gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
    }
}