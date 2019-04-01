using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class powerup : MonoBehaviour
{

  void OnMouseDrag()
      {
          float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
          transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));

      }

      void OnCollisionEnter(Collision coll){

    		if(coll.gameObject.name=="TouchCollider")
        {

          GameObject.Find("Fort").GetComponent<fort1>().TakeDamage1(10f);


        }
        else if(coll.gameObject.name=="TouchCollider (1)")
        {
          GameObject.Find("Fort (1)").GetComponent<fort>().TakeDamage(10f);
        }



}


}
