using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        Hub.Score = (Int32.Parse(Hub.Timer) + Int32.Parse(Hub.PointsLeft) + Int32.Parse(Hub.Score)).ToString();
        SceneManager.LoadScene("FinishLevel");
    }
}
