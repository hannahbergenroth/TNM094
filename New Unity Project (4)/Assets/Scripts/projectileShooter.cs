using UnityEngine;
using UnityEngine.EventSystems;

public class projectileShooter : MonoBehaviour
{
    Rigidbody rb;
    GameObject projectile;
    Vector3 startPos, endPos, direction;
    float shootPower = 11f;
    public GameObject prefab;

    void OnMouseDown()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        return ;

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
            endPos.z = 100f;
            direction = startPos - endPos;
            rb.AddForce(direction * shootPower);
        }
    }
}
