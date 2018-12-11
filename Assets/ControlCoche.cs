using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCoche : MonoBehaviour {
    public float Velocidad = 1f;


    void Update() {
        Input.GetKeyDown(KeyCode.D);
        if(Input.GetKeyDown(KeyCode.D)) {
            transform.Translate(new Vector3( Velocidad, 0f, 0f));
        }
    }
}
