using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour {

    public bool isKiller;

	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().color = getRGBColor();
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if(isKiller) SceneManager.LoadScene("YouLost");
    }

    Color getRGBColor()
    {
        int r, g, b, a;

        if (isKiller)
        {
            r = 225; g = 107; b = 147; a = 255;
        }
        else
        {
            r = 62; g = 62; b = 62; a = 255;
        }
        return new Color(r / 255.0f, g / 255.0f, b / 255.0f, a / 255.0f);
    }
}
