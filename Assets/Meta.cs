using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Meta : MonoBehaviour {
    public float velocidad;
    public string nombre;
    public KeyCode tecla = KeyCode.D;
    int cuenta = 0;
    public Text texto;
    public Text Ganador;
    public bool terminado = false;

    // Update is called once per frame
    void Update () {
        if (terminado == false)
        {
            if (Input.GetKeyDown(tecla))
            {
                    this.transform.Translate(new Vector3(velocidad, 0f, 0f));
                    cuenta++;
                    texto.text = "" + cuenta;
            }
        }
	}
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        print("colision");
        terminado = true;
        Ganador.text = "El ganador es " + nombre;
        Debug.Log("El ganador es " + nombre);
     
    }

}
