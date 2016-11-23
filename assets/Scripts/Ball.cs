using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    public float speed;
    public bool isKiller;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0.0f);
        GetComponent<SpriteRenderer>().color = getRGBColor();
        Scene scene = SceneManager.GetActiveScene();
        Hub.CurrentLevel = scene.name;
    }

    Color getRGBColor()
    {
        int r,g,b,a;

        if (isKiller)
        {
            r = 225; g = 107; b = 147; a = 255;
        } else {
            r = 80; g = 162; b = 183; a = 255;
        }
        return new Color(r / 255.0f, g / 255.0f, b / 255.0f, a / 255.0f);
    }
}
