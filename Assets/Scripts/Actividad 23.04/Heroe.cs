using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : Personaje
{
    private void Start()
    {
        nombre = "Carlos";
    }
    public override void Atacar()
    {
        Debug.Log("Ataque A Enemigo");
    }
}