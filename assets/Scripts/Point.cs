using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

    /// <summary>
    /// Detecta si ha sido impactado y, si es así, se auto destruye
    /// </summary>
    /// <param name="coll"></param>
    void OnCollisionExit2D(Collision2D coll)
    {
        GameObject[] point = GameObject.FindGameObjectsWithTag("Point");
        Destroy(point[0]);
    }
}
