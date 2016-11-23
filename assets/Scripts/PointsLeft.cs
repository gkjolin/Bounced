using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointsLeft : MonoBehaviour {
    
    private Text pointsLeftText;
    public int pointsLeft;

    // Use this for initialization
    void Start () {
        pointsLeftText = GetComponent<Text>();
        pointsLeftText.text = pointsLeft.ToString();
        Hub.PointsLeft = pointsLeft.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        pointsLeftText.text = Hub.PointsLeft;
    }
}
