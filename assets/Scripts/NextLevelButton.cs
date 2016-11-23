using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{

	void OnMouseDown()
    {
        SceneManager.LoadScene("LevelTwo");
    }
}
