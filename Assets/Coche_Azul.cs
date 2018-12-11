using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche_Azul : MonoBehaviour {
    public string Lugar;
    public GameObject Coche1;


	// Use this for initialization
	void Start () {
        Lugar = "Start";
        Debug.Log("Hemos llegado a: " + Lugar);
    }
	
	// Update is called once per frame
	void Update () {
        Lugar = "Undate";
        Debug.Log("Hemos llegado a: " + Lugar);
    }
}
