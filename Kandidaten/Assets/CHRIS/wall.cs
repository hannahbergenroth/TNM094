using UnityEngine;

public class Wall : MonoBehaviour {

	Collider col;
	GameObject prefab, wall;
	float distance = 14.5f;

	void Start()
	{
			prefab = Resources.Load("wall") as GameObject;
	}

	void OnMouseDown()
	{
        Debug.Log("hello");

	}

    public void PickUpWall()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        wall = Instantiate(prefab, Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity) as GameObject;
        col = wall.GetComponent<Collider>();
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        col.transform.position = objPosition;
    }



}
