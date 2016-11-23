using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RepeatButton : MonoBehaviour {

    void OnMouseDown()
    {
        SceneManager.LoadScene(Hub.CurrentLevel);
    }
}
