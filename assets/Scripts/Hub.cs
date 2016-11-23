using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Hub : MonoBehaviour{

    public static string Timer { get; set; }

    public static string PointsLeft { get; set; }

    public static string Score { get; set; }

    public static string CurrentLevel { get; set; }

    void Start()
    {
        Score = "0";
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("FinishLevel");
        }
    }
}
