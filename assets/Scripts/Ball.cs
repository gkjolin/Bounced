using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class Ball : MonoBehaviour {
    
    /// <summary>
    /// Crea dos variables públicas, una para determinar la velocidad y otra para indicar si es una bola Killer
    /// </summary>
    public float speed;
    public bool isKiller;

    /// <summary>
    /// Inicializa la bola con la velocidad especificada y obtiene el color dependiendo de si la bola es Killer o no
    /// </summary>
    void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0.0f);
        GetComponent<SpriteRenderer>().color = getRGBColor();
    }

    /// <summary>
    /// Detecta si la bola ha sufrido una colisión. Si es Killer, carga la pantalla "YouLost"
    /// </summary>
    /// <param name="coll"></param>
    void OnCollisionExit2D(Collision2D coll)
    {
        if (isKiller && coll.gameObject.name == "Ball") SceneManager.LoadScene("YouLost");
    }

    /// <summary>
    /// Determina el color de la bola dependiendo de si es Killer o no
    /// </summary>
    /// <returns></returns>
    private Color getRGBColor()
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
