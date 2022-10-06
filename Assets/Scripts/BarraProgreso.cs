using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraProgreso : MonoBehaviour
{
    Slider barra;
    private int cont = 0;

    private void Start()
    {
        cargar();
    }

    void Awake()
    {
        barra = GetComponent<Slider>();
    }

    void changeBarValue(float valor_act, float valor_max)
    {
        float porcentaje;
        porcentaje = valor_act / valor_max;
        barra.value = porcentaje;
    }

    void cargar()
    {
        cont++;
        changeBarValue(cont,10);
        if (cont <= 10)
        {
            Invoke("cargar",1f);

        }

    }

}
