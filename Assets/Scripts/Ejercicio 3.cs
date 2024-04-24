using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio3 : MonoBehaviour
{
    [SerializeField] private Text circulitos;
    [SerializeField] private Text rombitos;
    [SerializeField] private Text cuadraditos;

    private int circulitosCant = 0;
    private int rombitosCant = 0;
    private int cuadraditosCant = 0;
    private void Start()
    {
        UpdateUI();
    }
    public void AgregarObjeto(int v)
    {
        if (v == 1) { circulitosCant++; }
        if (v == 2) { rombitosCant++; }
        if (v == 3) { cuadraditosCant++; }
        else { Debug.Log("Error"); }

        UpdateUI();
    }

    public void QuitarObjeto(int v)
    {
        if (v == 1) { circulitosCant--; }
        if (v == 2) { rombitosCant--; }
        if (v == 3) { cuadraditosCant--; }
        else { Debug.Log("Error"); }
        if (circulitosCant <= 0) { circulitosCant = 0; }
        if (rombitosCant <= 0) { rombitosCant = 0; }
        if (cuadraditosCant <= 0) { cuadraditosCant = 0; }
        UpdateUI();
    }

    public void UpdateUI()
    {
        circulitos.text = circulitosCant.ToString();
        rombitos.text = rombitosCant.ToString();
        cuadraditos.text = cuadraditosCant.ToString();
    }
}