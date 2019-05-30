using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Followed tutorial from https://www.youtube.com/watch?v=VBZFYGWvm4A
*/

public class Grid : MonoBehaviour
{
    public float gridWidth = 40;
    public float gridHeight = 20;

    [SerializeField]
    private float size = 1f;

    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;

        int xCount = Mathf.RoundToInt(position.x / size);
        int yCount = Mathf.RoundToInt(position.y / size);
        int zCount = Mathf.RoundToInt(position.z / size);

        Vector3 result = new Vector3(
            (float)xCount * size,
            (float)yCount * size,
            (float)zCount * size);

        result += transform.position;

        return result;
    }

    //for debuggin, creates a visual representation of the grid
    /*
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        for (float z = 0; z < gridWidth; z += size)
        {
            for (float x = 0; x < gridHeight; x += size)
            {
                var point = GetNearestPointOnGrid(new Vector3(x, 0f, z));
                Gizmos.DrawSphere(point, 0.1f);
            }
                
        }
    }
    */
}