using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    private GameObject[] enemies;
    int sizeOfList;

    Rigidbody rb;
    GameObject prefab, projectilen;
    Vector3 direction, startPos, currentPos;
    float shootPower = 150f;

    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        sizeOfList = enemies.Length;

        prefab = Resources.Load("projectile") as GameObject;
    }

    void Update()
    {

    }

  //  void OnMouseDown()
  //  {
    //    float dist =  Mathf.Infinity;
      //  int index = 0;

        //for(int i=0; i<sizeOfList; i++)
        //{
          //float test = Vector3.Distance(transform.position, enemies[i].transform.position);

        //  if(test<dist)
        //  {
          //  dist = test;
        //    index = i;
        //  }
      //  }




        //projectilen = Instantiate(prefab, transform) as GameObject;
        //rb = projectilen.GetComponent<Rigidbody>();




        //  direction = enemies[index].transform.position-transform.position;
          //print(direction);



        //direction = new Vector3(1,1,1);

      //  rb.velocity = transform.TransformDirection (GameObject.Find("enemy").transform.position) * speed;

    //}
    //void OnMouseUp()
    //{
    //  rb.AddForce(direction * shootPower);
  //  }

void OnMouseDown()
{
    startPos = Input.mousePosition;
}


	void OnMouseDrag()
	{
    currentPos =Input.mousePosition;


     currentPos.z = 10.0f;
     currentPos = Camera.main.ScreenToWorldPoint(currentPos);

  //  Vector3 heja = GameObject.Find("Cube").transform.position;



    float a = currentPos.y;
    float b = currentPos.x+4;

float arctan = Mathf.Atan(a/b)* (180/Mathf.PI);
print(arctan);

transform.Rotate(0, 0, arctan, Space.World);

}
}
