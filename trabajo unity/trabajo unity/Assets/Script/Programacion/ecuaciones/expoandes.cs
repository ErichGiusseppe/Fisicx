using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class expoandes : MonoBehaviour
{

    public Text respuesta;
    public InputField graveda;
    public InputField velocidadinicial;
    public InputField velocidadfinal;
    public InputField tiempo;
    public InputField posiciony;

    public void funciones()
    {
        if(velocidadfinal.text == "" && velocidadinicial.text != "" && graveda.text != "" && tiempo.text != "")
        {
            float VelocidadInicial = float.Parse(velocidadinicial.text);
            float Gravedad = float.Parse(graveda.text);
            float Tiempo = float.Parse(tiempo.text);

            float operacion = VelocidadInicial + (Gravedad * Tiempo);
            respuesta.text = operacion.ToString();
        }
        if (velocidadfinal.text == "" && velocidadinicial.text != "" && graveda.text != "" && posiciony.text != "")
        {
            float velocidad_inicial = float.Parse(velocidadinicial.text);
            float gravedad = float.Parse(graveda.text);
            float y = float.Parse(posiciony.text);
            double result = Math.Sqrt(Math.Pow(velocidad_inicial, 2) + ((2 * gravedad) * y));
            respuesta.text = result.ToString();
        }
        if (velocidadfinal.text == "" && velocidadinicial.text != "" && posiciony.text != "" && tiempo.text != "")
        {
            float velocidad_inicial = float.Parse(velocidadinicial.text);
            float y = float.Parse(posiciony.text);
            float Tiempo = float.Parse(tiempo.text);
            double res = ((y * 2) / Tiempo) - velocidad_inicial;
            respuesta.text = res.ToString();
        }
        if (velocidadinicial.text == "" && velocidadfinal.text != "" && graveda.text != "" && tiempo.text != "")
        {
            float velocidad_final = float.Parse(velocidadfinal.text);
            float gravedad = float.Parse(graveda.text);
            float Tiempo = float.Parse(tiempo.text);
            float respuestas = velocidad_final / (gravedad * Tiempo);
            respuesta.text = respuestas.ToString();

        }
        if (velocidadinicial.text == "" && graveda.text != "" && tiempo.text != "" && posiciony.text != "")
        {
            float gravedad = float.Parse(graveda.text);
            float Tiempo = float.Parse(tiempo.text);
            float y = float.Parse(posiciony.text);
            double respuestas = (y - (((1 / 2) * gravedad) * Math.Pow(Tiempo, 2))) / Tiempo;
            respuesta.text = respuestas.ToString();
        }
        if (velocidadinicial.text == "" && velocidadfinal.text != "" && posiciony.text != "" && graveda.text != "")
        {
            float velocidad_final = float.Parse(velocidadfinal.text);
            float y = float.Parse(posiciony.text);
            float gravedad = float.Parse(graveda.text);
            double respuestas = Math.Sqrt(velocidad_final - ((2 * gravedad) * y));
            respuesta.text = respuestas.ToString();
        }
        if (velocidadinicial.text == "" && velocidadfinal.text != "" && posiciony.text != "" && tiempo.text != "")
        {
            float velocidad_final = float.Parse(velocidadfinal.text);
            float y = float.Parse(posiciony.text);
            float Tiempo = float.Parse(tiempo.text);

            double respuestas = ((y * 2) / Tiempo) - velocidad_final;
            respuesta.text = respuestas.ToString();

        }
        if (graveda.text != "" && velocidadfinal.text != "" && velocidadinicial.text != "" && tiempo.text != "")
        {
            float velocidad_final = float.Parse(velocidadfinal.text);
            float velocidad_inicial = float.Parse(velocidadinicial.text);
            float tiempos = float.Parse(tiempo.text);
            float respuestas = (velocidad_final - velocidad_inicial) / tiempos;
            respuesta.text = respuestas.ToString();
        }
        if (tiempo.text == "" && velocidadfinal.text != "" && velocidadinicial.text != "" && graveda.text != "")
        {
            float velocidadf = float.Parse(velocidadfinal.text);
            float velocidadi = float.Parse(velocidadinicial.text);
            float gravedad = float.Parse(graveda.text);
            float respuestas = (velocidadf - velocidadi) / gravedad;
            respuesta.text = respuestas.ToString();
        }
        if (posiciony.text == "" && velocidadinicial.text != "" && tiempo.text != "" && graveda.text != "")
        {
            float vi = float.Parse(velocidadinicial.text);
            float tie = float.Parse(tiempo.text);
            float grav = float.Parse(graveda.text);
            double respuestas = (vi * tie) + (((1 / 2) * grav) * Math.Pow(tie, 2));
            respuesta.text = respuestas.ToString();

        }
        if (graveda.text == "" && posiciony.text != "" && velocidadinicial.text != "" && tiempo.text != "")
        {
            float y = float.Parse(posiciony.text);
            float vi = float.Parse(velocidadinicial.text);
            float tie = float.Parse(tiempo.text);
            double respuestas = (2 * (y - (vi * tie))) / Math.Pow(tie, 2);
            respuesta.text = respuestas.ToString();

        }
        if (posiciony.text != "" && velocidadfinal.text != "" && velocidadinicial.text != "" && graveda.text != "")
        {
            float vi = float.Parse(velocidadinicial.text);
            float vf = float.Parse(velocidadfinal.text);
            float gra = float.Parse(graveda.text);
            double respuestas = (Math.Pow(vf, 2) - Math.Pow(vi, 2)) / (2 * gra);
            respuesta.text = respuestas.ToString();

        }
        if (graveda.text == "" && velocidadfinal.text != "" && velocidadinicial.text != "" && posiciony.text != "")
        {
            float vf = float.Parse(velocidadfinal.text);
            float vi = float.Parse(velocidadinicial.text);
            float y = float.Parse(posiciony.text);
            double respuestas = (Math.Pow(vf, 2) - Math.Pow(vi, 2)) / (2 * y);
            respuesta.text = respuestas.ToString();

        }
        if (posiciony.text == "" && velocidadinicial.text != "" && velocidadfinal.text != "" && tiempo.text != "")
        {
            float vi = float.Parse(velocidadinicial.text);
            float vf = float.Parse(velocidadfinal.text);
            float tie = float.Parse(tiempo.text);
            float respuestas = ((vi + vf) / 2);
            respuesta.text = respuestas.ToString();

        }
        if (tiempo.text != "" && posiciony.text != "" && velocidadinicial.text != "" && velocidadfinal.text != "")
        {
            float y = float.Parse(posiciony.text);
            float vi = float.Parse(velocidadinicial.text);
            float vf = float.Parse(velocidadfinal.text);
            float respuesats = (2 * y) / (vi + vf);
            respuesta.text = respuesats.ToString();

        }
        if (tiempo.text == "" && velocidadfinal.text != "" && velocidadinicial.text != "" && posiciony.text != "" && graveda.text != "")
        {
            float vf = float.Parse(velocidadfinal.text);
            float vi = float.Parse(velocidadinicial.text);
            float y = float.Parse(posiciony.text);
            float gra = float.Parse(graveda.text);
            float respuestas = (y - vi) / ((1 / 2) *gra);
            respuesta.text = respuestas.ToString();
        } 
    }



  
}
