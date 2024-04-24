using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Personaje : MonoBehaviour
{
    protected string nombre;
    public virtual void Atacar()
    {
        Debug.Log("Ataque básico");
    }
}