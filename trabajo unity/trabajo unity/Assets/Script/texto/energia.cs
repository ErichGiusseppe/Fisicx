using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class energia : MonoBehaviour
{
    public Text respuesta;
    public Text ecuacion;
    public InputField epotencial;
    public InputField ecinetica;
    public InputField masa;
    public InputField gravedad;
    public InputField altura;
    public InputField velocidad;
    public InputField fuerzaroce;
    public InputField fuerzanormal;
    public InputField coeficienteroce;

    public void energias()
    {
        if (epotencial.text == "" && masa.text != "" && gravedad.text != "" && altura.text != "")
        {
            float m = float.Parse(masa.text);
            float g = float.Parse(gravedad.text);
            float a = float.Parse(altura.text);
            float operacion = m * g * a;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(m)*(g)*(a)";
            respuesta.text = "Energia potencial= " + operacion.ToString();

        }
        else if (masa.text == "" && gravedad.text != "" && epotencial.text != "" && altura.text != "")
        {
            float g = float.Parse(gravedad.text);
            float ep = float.Parse(epotencial.text);
            float a = float.Parse(altura.text);
            float operacion = ep / (g * a);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: ep / (g * a)"; 
            respuesta.text ="masa= "+ operacion.ToString();
        }
        else if (gravedad.text == "" && masa.text != "" && epotencial.text != "" && altura.text != "")
        {
            float m = float.Parse(masa.text);
            float ep = float.Parse(epotencial.text);
            float a = float.Parse(altura.text);
            float operacion = ep / (a * m);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: ep/(a*m)";
            respuesta.text ="gravedad= " + operacion.ToString();
        }
        else if (altura.text == "" && gravedad.text != "" && masa.text != "" && epotencial.text != "")
        {
            float g = float.Parse(gravedad.text);
            float m = float.Parse(masa.text);
            float ep = float.Parse(epotencial.text);
            float operacion = ep / (m * g);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: ep/(m*g)";
            respuesta.text = "altura= "+operacion.ToString();

        }
        else if (ecinetica.text == "" && masa.text != "" && velocidad.text != "")
        {
            float m = float.Parse(masa.text);
            float v = float.Parse(velocidad.text);
            double operacion = (1 / 2) * (m * (Math.Pow(v, 2)));
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(1/2)*m*(v^2)";
            respuesta.text ="energia cinetica= "+ operacion.ToString();
        }
        else if (velocidad.text == "" && ecinetica.text != "" && masa.text != "")
        {
            float ec = float.Parse(ecinetica.text);
            float m = float.Parse(masa.text);
            double operacion = Math.Sqrt((ec * 2) / m);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:√(ec*2)/m)";
            respuesta.text ="velocidad= " +operacion.ToString();
        }
        else if (masa.text == "" && velocidad.text != "" && ecinetica.text != "")
        {
            float v = float.Parse(velocidad.text);
            float ec = float.Parse(ecinetica.text);
            double operacion = (ec * 2) / Math.Pow(v, 2);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(ec*2)/v^2";
            respuesta.text ="masa= " +operacion.ToString();

        }
        else if (fuerzaroce.text == "" && coeficienteroce.text != "" && fuerzanormal.text != "")
        {
            float cf = float.Parse(coeficienteroce.text);
            float n = float.Parse(fuerzanormal.text);
            float operacion = cf * n;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: cf*n";
            respuesta.text ="fuerza de roce= "+ operacion.ToString();
        }
        else if (coeficienteroce.text == "" && fuerzaroce.text != "" && fuerzanormal.text != "")
        {
            float fr = float.Parse(fuerzaroce.text);
            float n = float.Parse(fuerzanormal.text);
            float operacion = fr / n;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:fr/n";
            respuesta.text = "coeficiente de roce= "+operacion.ToString();
        }
        else if (fuerzanormal.text == "" && fuerzaroce.text != "" && coeficienteroce.text != "")
        {
            float u = float.Parse(coeficienteroce.text);
            float fr = float.Parse(fuerzaroce.text);
            float operacion = fr / u;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:fr/u";
            respuesta.text = "fuerca de roce= "+operacion.ToString();
        }
        else
        {
            respuesta.text = "No hay suficientes datos para calcular alguna variable";
        }
    }
}
