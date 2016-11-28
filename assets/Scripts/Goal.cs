using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    /// <summary>
    /// Si recibe una colisión de la bola carga la escena "FinishLevel" e incrementa el score con la puntuación
    /// </summary>
    /// <param name="coll"></param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        Hub.OldScore = Hub.Score;
        Hub.Score = (Int32.Parse(Hub.Timer) + Int32.Parse(Hub.PointsLeft) + Int32.Parse(Hub.Score)).ToString();
        SceneManager.LoadScene("FinishLevel");
    }
}
