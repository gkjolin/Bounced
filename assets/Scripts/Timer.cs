using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;
    public float myTimer;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        myTimer -= Time.deltaTime;
        Hub.Timer = myTimer.ToString("f0");
        timerText.text = Hub.Timer;
    }
}
