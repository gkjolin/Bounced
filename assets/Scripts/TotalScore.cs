using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = Hub.Score;
    }
}
