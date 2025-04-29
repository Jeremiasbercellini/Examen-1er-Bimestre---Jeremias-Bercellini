using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTV : MonoBehaviour
{
    public string patente;
    public int modelo;
    public float kilometrosRecorridos;
    public int vencimientoVTVactual;
    public float HCppm;
    int promedio;
    int años;

    // Start is called before the first frame update
    void Start()
    {
        if (patente = 0)
        {
            Debug.Log("Error, patente no ingresada. VTV no aprobada");
            return;
        }
        else if (modelo > 2025 || modelo < 1900)
        {
            Debug.Log("Error, modelo invalido. VTV no aprobada");
            return;
        }
        else if (kilometrosRecorridos <= 0)
        {
            Debug.Log("Error, kilometraje invalido. VTV no aprobada");
            return;
        }
        else if (vencimientoVTVactual < modelo || vencimientoVTVactual > 2025)
        {
            Debug.Log("Error, fecha no valida. VTV no aprobada");
            return;
        }
         else if(HCppm < 5)
        {
            Debug.Log("Error, valor no valido en HC ppm. VTV no aprobada");
            return;
        }
        else
        {
            if(HCppm > 100)
            {
                Debug.Log("Niveles de HC ppm muy elevados. VTV no aprobada");
            }
            else
            {
                años = 2025 - modelo;
                promedio = kilometrosRecorridos / años;
                if(promedio < 10000)
                {
                    Debug.Log("VTV aprobada y otorgada por dos años");
                }
                else
                {
                    Debug.Log("VTV aprobada y otorgada por un año");
                }
            }
        }
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
