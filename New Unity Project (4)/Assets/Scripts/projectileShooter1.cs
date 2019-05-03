using UnityEngine;
using UnityEngine.EventSystems;

public class projectileShooter1 : MonoBehaviour
{
    Rigidbody rb;
    GameObject prefab, projectile;
    Vector3 startPos, endPos, direction;
    float shootPower = 11f;


    void Start()
    {
        prefab = Resources.Load("projectile1") as GameObject;
    }

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
            rb.useGravity=false;
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
            rb.useGravity=true;
        }
    }

}
