using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingExperiment : MonoBehaviour {
    public GameObject car1;
    Vector3 mover = new Vector3(-1f,0f,0f);


    void Update() {
        car1.transform.Translate(mover);
    }
}
