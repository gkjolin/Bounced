using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour {

    /// <summary>
    /// Variable que determina si el bloque es Killer o no
    /// </summary>
    public bool isKiller;

	/// <summary>
    /// Carga el color del bloque
    /// </summary>
	void Start () {
        GetComponent<SpriteRenderer>().color = getRGBColor();
    }

    /// <summary>
    /// Si el bloque es impactado y es Killer carga la escena "YouLost"
    /// </summary>
    void OnCollisionExit2D()
    {
        if(isKiller) SceneManager.LoadScene("YouLost");
    }

    /// <summary>
    /// Determina el color del bloque dependiendo de si es Killer o no
    /// </summary>
    /// <returns></returns>
    private Color getRGBColor()
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
