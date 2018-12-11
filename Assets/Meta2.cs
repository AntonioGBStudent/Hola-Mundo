using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Meta2 : MonoBehaviour
{
    public float velocidad;
    public string nombre;
    public KeyCode tecla = KeyCode.D;
    int cuenta = 0;
    public Text texto;
    public Text Ganador;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cuenta > 26)
        {
            Ganador.text = "El ganador es " + nombre;
            Debug.Log("El ganador es " + nombre);
        }
        else
        {
            if (Input.GetKeyDown(tecla))
            {
                this.transform.Translate(new Vector3(velocidad, 0f, 0f));
                cuenta++;
                texto.text = "" + cuenta;
            }
        }
    }
}
