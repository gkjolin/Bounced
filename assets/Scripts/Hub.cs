using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Hub : MonoBehaviour{

    /// <summary>
    /// Determina las variables globales que usará el juego
    /// </summary>
    public static string Timer { get; set; }
    public static string PointsLeft { get; set; }
    public static string Score { get; set; }
    public static string OldScore { get; set; }
    public static int CurrentLevel { get; set; }
    public static int NumberOfLevels { get; set; }

    /// <summary>
    /// Inicializa el número de niveles que tiene el juego
    /// </summary>
    void Start()
    {
        NumberOfLevels = 4;
    }

    /// <summary>
    /// Detecta si se ha acabado el tiempo o los puntos disponibles
    /// y si llegan a cero carga la escena "YouLost", además, detecta si
    /// la tecla "back" del movil se ha pulsado y si es así carga la escena "FinishLevel"
    /// </summary>
    void Update()
    {
        if(PointsLeft == "0" || Timer == "0")
        {
            if(SceneManager.GetActiveScene().name != "YouLost")
                SceneManager.LoadScene("YouLost");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("FinishLevel");
        }
    }
}
