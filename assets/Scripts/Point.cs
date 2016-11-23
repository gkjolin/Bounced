using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

    void OnCollisionExit2D(Collision2D coll)
    {
        GameObject[] point = GameObject.FindGameObjectsWithTag("Point");
        Destroy(point[0]);
    }
}
