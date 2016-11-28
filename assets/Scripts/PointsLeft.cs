using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointsLeft : MonoBehaviour {
    
    /// <summary>
    /// Determina las variables que mostrará el texto de los puntos disponibles
    /// e indica los puntos iniciales
    /// </summary>
    private Text pointsLeftText;
    public int pointsLeft;

    /// <summary>
    /// Inicializa el número de puntos disponibles al inicio del nivel
    /// </summary>
    void Start () {
        if (pointsLeft == 0) pointsLeft = 10;
        pointsLeftText = GetComponent<Text>();
        pointsLeftText.text = pointsLeft.ToString();
        Hub.PointsLeft = pointsLeft.ToString();
    }
	
	/// <summary>
    /// Refresca el número de puntos restante
    /// </summary>
	void Update () {
        pointsLeftText.text = Hub.PointsLeft;
    }
}
