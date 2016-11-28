using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class Background : MonoBehaviour {

    /// <summary>
    /// Variable que definirá el objeto Point
    /// </summary>
    public GameObject bouncePoint;

    /// <summary>
    /// Se llama al iniciarse la clase: Destruye cualquier punto que exista en la pantalla y define el nivel actual
    /// </summary>
    void Start()
    {
        if(GameObject.FindGameObjectsWithTag("Point").Length != 0)
            Destroy(GameObject.FindGameObjectsWithTag("Point")[0]);

        Hub.CurrentLevel = Int32.Parse(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// Cuando se pulsa el ratón detecta si exixte algún punto en el juego, si es así, lo destruye y crea uno nuevo
    /// en las coordenadas desde donde se ha pulsado el ratón, si no existe ninguno, lo crea
    /// </summary>
    void OnMouseDown()
    {
        GameObject[] point = GameObject.FindGameObjectsWithTag("Point");

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

    /// <summary>
    /// Decrementa el contador de puntos restantes (PointsLeft)
    /// </summary>
    /// <returns></returns>
    private string DecreasePointCounter ()
    {
        int pointsCount = Int32.Parse(Hub.PointsLeft);
        return (pointsCount - 1).ToString();
    }
}
