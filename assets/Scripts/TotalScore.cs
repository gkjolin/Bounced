using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour {

	/// <summary>
    /// Muestra el Score final cuando finaliza el juego
    /// </summary>
	void Start () {
        GetComponent<Text>().text = Hub.Score;
    }
}
