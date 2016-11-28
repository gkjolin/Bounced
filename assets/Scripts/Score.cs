using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour {

    /// <summary>
    /// Determina las variables que mostrará el texto del Score
    /// e indica el score inicial
    /// </summary>
    public Text scoreText;
    public string initialScore;

    /// <summary>
    /// Inicializa el score al inicio del nivel, si este no tiene valor, lo inicializa a cero
    /// </summary>
    void Start () {
        scoreText = GetComponent<Text>();
        if (String.IsNullOrEmpty(Hub.Score))
        {
            Hub.Score = (String.IsNullOrEmpty(initialScore))? "0" : initialScore;
            Hub.OldScore = Hub.Score;
        }

    }
	
	/// <summary>
    /// Refresca el texto del Score
    /// </summary>
	void Update () {
        scoreText.text = Hub.Score;
    }
}
