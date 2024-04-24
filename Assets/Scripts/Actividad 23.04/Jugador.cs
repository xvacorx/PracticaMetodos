using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Heroe
{
    float vida = 10f;
    float speed = 5f;

    private void Start()
    {
        Debug.Log("Hola " + nombre);
        Atacar();
    }

}
