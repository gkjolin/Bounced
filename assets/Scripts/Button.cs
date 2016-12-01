using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

    /// <summary>
    /// Variable que indica a qué botón se asocia en la escena
    /// </summary>
    public GameObject button;
    int milliseconds = 400;

    /// <summary>
    /// Cuando detecta una pulsada del ratón determina qué tipo de botón es:
    /// *BackButton: Vuelve al menú principal
    /// *InfoButton: Carga la pantalla de créditos
    /// *PlayButton: Empieza el juego
    /// *ExitButton: Sale del juego
    /// *RepeatButton: Repite la escena
    /// *PlayAgaintButton: Empieza el juego
    /// *NextLevelButton: Carga el siguiente nivel
    /// 
    /// Algunos botones tiene un delay de 400 milisegundos para dar tiempo a
    /// levantar el dedo de la pantalla antes de que cambie la escena.
    /// </summary>
    void OnMouseDown()
    {
        switch(button.name){
            case "BackButton":
                SceneManager.LoadScene("MainMenu");
                break;
            case "InfoButton":
                SceneManager.LoadScene("Credits");
                break;
            case "PlayButton":
                DeletePoints();
                Thread.Sleep(milliseconds);
                SceneManager.LoadScene("1");
                break;
            case "ExitButton":
                Application.Quit();
                break;
            case "RepeatButton":
                DeletePoints();
                Thread.Sleep(milliseconds);
                Hub.Score = Hub.OldScore;
                SceneManager.LoadScene(Hub.CurrentLevel.ToString());
                break;
            case "PlayAgaintButton":
                DeletePoints();
                Thread.Sleep(milliseconds);
                SceneManager.LoadScene("1");
                Hub.CurrentLevel = 1;
                Hub.Score = "0";
                Hub.OldScore = "0";
                break;
            case "NextLevelButton":
                Thread.Sleep(milliseconds);
                DeletePoints();
                if (Hub.CurrentLevel < Hub.NumberOfLevels)
                {
                    Hub.OldScore = Hub.Score;
                    Hub.CurrentLevel++;
                    SceneManager.LoadScene(Hub.CurrentLevel.ToString());
                }
                else
                {
                    SceneManager.LoadScene("EndOfGame");
                }
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Recorre la escena en busca de puntos y los elimina
    /// </summary>
    private void DeletePoints()
    {
        GameObject[] points = GameObject.FindGameObjectsWithTag("Point");
        if (points != null) {
            foreach (GameObject gameObject in points)
            {
                Destroy(gameObject);
            }
        }
    }
}
