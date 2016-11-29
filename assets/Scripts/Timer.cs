using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    /// <summary>
    /// Determina las variables que mostrará el texto del Timer
    /// e indica el tiempo inicial
    /// </summary>
    public Text timerText;
    public float myTimer;

    /// <summary>
    /// Inicializa el timer, si este no tiene valor, lo inicializa a 30 segundos
    /// </summary>
	void Start () {
        timerText = GetComponent<Text>();
        if (myTimer == 0f) myTimer = 30f;
	}
	
	/// <summary>
    /// Decrementa el timer cada segundo
    /// </summary>
	void Update () {
        myTimer -= Time.deltaTime;
        Hub.Timer = myTimer.ToString("f0");
        timerText.text = Hub.Timer;
    }
}
