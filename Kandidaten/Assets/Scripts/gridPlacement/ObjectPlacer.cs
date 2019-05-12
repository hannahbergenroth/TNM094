using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Followed tutorial from https://www.youtube.com/watch?v=VBZFYGWvm4A
*/

public class ObjectPlacer : MonoBehaviour
{
    //Array of all prefabs to be spawned
    public GameObject[] trees;
    public float minSpawnTime = 0;
    public float maxSpawnTime = 2;
    public float radius = 1;

    private float spawnWait;
    private Grid grid;
    private IEnumerator coroutine;

    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
    }

    private void Start()
    {
        StartCoroutine(waitSpawner());
    }

    private void Update()
    {
        spawnWait = Random.Range(minSpawnTime, maxSpawnTime);
        
        //spawn from clicking, not to be used for trees
        /*
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                //Kolla så att inte position redan ockuperad
                if (hitInfo.transform.tag != "Untagged")
                {
                    PlaceCubeNear(hitInfo.point);
                }
            }
        }*/
    }

    private IEnumerator waitSpawner()
    {
        //yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        float radius = 1;

        while(true)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(0, grid.gridHeight-1), 0f, Random.Range(0, grid.gridWidth-1));
            var finalPosition = grid.GetNearestPointOnGrid(spawnPoint);
            Vector3 comparePoint = finalPosition + new Vector3(0f, 1.2f, 0f);
            //check if object already is at position
            if (!Physics.CheckSphere(comparePoint, radius))
            {
                PlaceObjectNear(finalPosition);
            }
            yield return new WaitForSeconds(spawnWait);
        }
    }

    //snap to position and spawn
    private void PlaceObjectNear(Vector3 clickPoint)
    {
        GameObject tree = (GameObject)Instantiate(trees[Random.Range(0,trees.Length)], clickPoint, transform.rotation);

        //Create standardObject on snapped position or original
        //GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = finalPosition;
        //GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = nearPoint;
    }
}