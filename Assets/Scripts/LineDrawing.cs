using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawing : MonoBehaviour
{
    public LineRenderer lr;
    public List<Vector2> listOfPoints;
    // Start is called before the first frame update
    void Start()
    {
        listOfPoints = new List<Vector2>();
        lr.positionCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            listOfPoints.Add(newPosition);

            lr.positionCount++;
            lr.SetPosition(lr.positionCount - 1, newPosition);
        }

        if (Input.GetMouseButtonDown(1))
        {
            listOfPoints = new List<Vector2>();
            lr.positionCount = 0;
        }

    }
}
