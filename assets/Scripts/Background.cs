using UnityEngine;
using System.Collections;
using System;

public class Background : MonoBehaviour {

    public GameObject bouncePoint;

    void OnMouseDown()
    {
        GameObject[] point = GameObject.FindGameObjectsWithTag("Point");
        GameObject[] pointsLeft = GameObject.FindGameObjectsWithTag("PointsLeft");

        if (point.Length > 0)
        {
            Destroy(point[0]);
            Hub.PointsLeft = DecreasePointCounter();
            GameObject newObject = Instantiate(bouncePoint);
            newObject.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, -0.0f);
        }
        else
        {
            GameObject newObject = Instantiate(bouncePoint);
            Hub.PointsLeft = DecreasePointCounter();
            newObject.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, -0.0f);
        }
    }

    string DecreasePointCounter ()
    {
        int pointsCount = Int32.Parse(Hub.PointsLeft);
        return (pointsCount - 1).ToString();
    }
}
