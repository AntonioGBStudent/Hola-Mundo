using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public interface Iestoyhastalosdestecodigo : IEventSystemHandler
{
    void Puntos(int valor);
}

public class ControldeCanvas : MonoBehaviour, Iestoyhastalosdestecodigo
{
    public Text texto;

    public void Puntos(int valor)
    {
        texto.text = "Puntos: " + valor;
    }
}
