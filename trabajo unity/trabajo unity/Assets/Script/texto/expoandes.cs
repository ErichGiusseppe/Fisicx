using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class expoandes : MonoBehaviour
{

    public Text respuesta;
    public Text ecuacion;
    public InputField graveda;
    public InputField velocidadinicial;
    public InputField velocidadfinal;
    public InputField tiempo;
    public InputField posiciony;
    public InputField epotencial;
    public InputField ecinetica;
    public InputField masa;
    public InputField altura;
    public InputField velocidad;
    public InputField fuerzaroce;
    public InputField fuerzanormal;
    public InputField coeficienteroce;


    public void funciones()
    {
        if(velocidadfinal.text == "" && velocidadinicial.text != "" && graveda.text != "" && tiempo.text != "")
        {
            float VelocidadInicial = float.Parse(velocidadinicial.text);
            float Gravedad = float.Parse(graveda.text);
            float Tiempo = float.Parse(tiempo.text);

            float operacion = VelocidadInicial + (Gravedad * Tiempo);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:Vi+(g*t)";
            respuesta.text = "velocidad final= "+operacion.ToString();
        }
        else if (velocidadfinal.text == "" && velocidadinicial.text != "" && graveda.text != "" && posiciony.text != "")
        {
            float velocidad_inicial = float.Parse(velocidadinicial.text);
            float gravedad = float.Parse(graveda.text);
            float y = float.Parse(posiciony.text);
            double result = Math.Sqrt(Math.Pow(velocidad_inicial, 2) + ((2 * gravedad) * y));
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(√v^2)+((2*g)*y)"; 
            respuesta.text ="velocidad final= " +result.ToString();
        }
        else if (velocidadfinal.text == "" && velocidadinicial.text != "" && posiciony.text != "" && tiempo.text != "")
        {
            float velocidad_inicial = float.Parse(velocidadinicial.text);
            float y = float.Parse(posiciony.text);
            float Tiempo = float.Parse(tiempo.text);
            double res = ((y * 2) / Tiempo) - velocidad_inicial;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:((y*2)/t)-Vi";
            respuesta.text = "velocidad final= "+res.ToString();
        }
        else if (velocidadinicial.text == "" && velocidadfinal.text != "" && graveda.text != "" && tiempo.text != "")
        {
            float velocidad_final = float.Parse(velocidadfinal.text);
            float gravedad = float.Parse(graveda.text);
            float Tiempo = float.Parse(tiempo.text);
            float respuestas = velocidad_final / (gravedad * Tiempo);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:Vf/(g*t)";
            respuesta.text ="velocidad inicial= "+ respuestas.ToString();

        }
        else if (velocidadinicial.text == "" && graveda.text != "" && tiempo.text != "" && posiciony.text != "")
        {
            float gravedad = float.Parse(graveda.text);
            float Tiempo = float.Parse(tiempo.text);
            float y = float.Parse(posiciony.text);
            double respuestas = (y - (((1 / 2) * gravedad) * Math.Pow(Tiempo, 2))) / Tiempo;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(y-(((1/2)*g)*(t^2/t)";
            respuesta.text = "velocidad inicial= "+respuestas.ToString();
        }
        else if (velocidadinicial.text == "" && velocidadfinal.text != "" && posiciony.text != "" && graveda.text != "")
        {
            float velocidad_final = float.Parse(velocidadfinal.text);
            float y = float.Parse(posiciony.text);
            float gravedad = float.Parse(graveda.text);
            double respuestas = Math.Sqrt(velocidad_final - ((2 * gravedad) * y));
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:√(Vf-((2*g)*y)";
            respuesta.text ="velocidad inicial= " + respuestas.ToString();
        }
        else if (velocidadinicial.text == "" && velocidadfinal.text != "" && posiciony.text != "" && tiempo.text != "")
        {
            float velocidad_final = float.Parse(velocidadfinal.text);
            float y = float.Parse(posiciony.text);
            float Tiempo = float.Parse(tiempo.text);

            double respuestas = ((y * 2) / Tiempo) - velocidad_final;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:((2*y)/t)-Vf";
            respuesta.text ="velocidad inicial= " +respuestas.ToString();

        }
        else if (graveda.text != "" && velocidadfinal.text != "" && velocidadinicial.text != "" && tiempo.text != "")
        {
            float velocidad_final = float.Parse(velocidadfinal.text);
            float velocidad_inicial = float.Parse(velocidadinicial.text);
            float tiempos = float.Parse(tiempo.text);
            float respuestas = (velocidad_final - velocidad_inicial) / tiempos;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(Vf-Vi)/t";
            respuesta.text = "gravedad= "+respuestas.ToString();
        }
        else if (tiempo.text == "" && velocidadfinal.text != "" && velocidadinicial.text != "" && graveda.text != "")
        {
            float velocidadf = float.Parse(velocidadfinal.text);
            float velocidadi = float.Parse(velocidadinicial.text);
            float gravedad = float.Parse(graveda.text);
            float respuestas = (velocidadf - velocidadi) / gravedad;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(Vf-Vi)/g";
            respuesta.text = "tiempo= "+respuestas.ToString();
        }
        else if (posiciony.text == "" && velocidadinicial.text != "" && tiempo.text != "" && graveda.text != "")
        {
            float vi = float.Parse(velocidadinicial.text);
            float tie = float.Parse(tiempo.text);
            float grav = float.Parse(graveda.text);
            double respuestas = (vi * tie) + (((1 / 2) * grav) * Math.Pow(tie, 2));
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(Vi*t)+(((1/2)*g)*t^2)";
            respuesta.text = "posicion en y= "+respuestas.ToString();

        }
        else if (graveda.text == "" && posiciony.text != "" && velocidadinicial.text != "" && tiempo.text != "")
        {
            float y = float.Parse(posiciony.text);
            float vi = float.Parse(velocidadinicial.text);
            float tie = float.Parse(tiempo.text);
            double respuestas = (2 * (y - (vi * tie))) / Math.Pow(tie, 2);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(2*(y-(Vi*t)))/t^2";
            respuesta.text = "gravedad= "+respuestas.ToString();

        }
        else if (posiciony.text != "" && velocidadfinal.text != "" && velocidadinicial.text != "" && graveda.text != "")
        {
            float vi = float.Parse(velocidadinicial.text);
            float vf = float.Parse(velocidadfinal.text);
            float gra = float.Parse(graveda.text);
            double respuestas = (Math.Pow(vf, 2) - Math.Pow(vi, 2)) / (2 * gra);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(Vf^2-Vi^2)(2*g)";
            respuesta.text = "posicion en y"+ respuestas.ToString();

        }
        else if (graveda.text == "" && velocidadfinal.text != "" && velocidadinicial.text != "" && posiciony.text != "")
        {
            float vf = float.Parse(velocidadfinal.text);
            float vi = float.Parse(velocidadinicial.text);
            float y = float.Parse(posiciony.text);
            double respuestas = (Math.Pow(vf, 2) - Math.Pow(vi, 2)) / (2 * y);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(Vf^2-Vi^2)/(2*y)";
            respuesta.text = "gravedad= "+respuestas.ToString();

        }
        else if (posiciony.text == "" && velocidadinicial.text != "" && velocidadfinal.text != "" && tiempo.text != "")
        {
            float vi = float.Parse(velocidadinicial.text);
            float vf = float.Parse(velocidadfinal.text);
            float tie = float.Parse(tiempo.text);
            float respuestas = ((vi + vf) / 2);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:((Vi+Vf)/2)";
            respuesta.text = "posicion en y= "+respuestas.ToString();

        }
        else if (tiempo.text != "" && posiciony.text != "" && velocidadinicial.text != "" && velocidadfinal.text != "")
        {
            float y = float.Parse(posiciony.text);
            float vi = float.Parse(velocidadinicial.text);
            float vf = float.Parse(velocidadfinal.text);
            float respuesats = (2 * y) / (vi + vf);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(2*y)/(Vi+Vf)";
            respuesta.text ="tiempo= "+ respuesats.ToString();

        }
        else if (tiempo.text == "" && velocidadfinal.text != "" && velocidadinicial.text != "" && posiciony.text != "" && graveda.text != "")
        {
            float vf = float.Parse(velocidadfinal.text);
            float vi = float.Parse(velocidadinicial.text);
            float y = float.Parse(posiciony.text);
            float gra = float.Parse(graveda.text);
            float respuestas = (y - vi) / ((1 / 2) *gra);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(y-Vi)/((1/2)*g)";
            respuesta.text = "tiempo= "+respuestas.ToString();
        }

        if (epotencial.text == "" && masa.text != "" && graveda.text != "" && altura.text != "")
        {
            float m = float.Parse(masa.text);
            float g = float.Parse(graveda.text);
            float a = float.Parse(altura.text);
            float operacion = m * g * a;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(m)*(g)*(a)";
            respuesta.text = "Energia potencial= " + operacion.ToString();

        }
        else if (masa.text == "" && graveda.text != "" && epotencial.text != "" && altura.text != "")
        {
            float g = float.Parse(graveda.text);
            float ep = float.Parse(epotencial.text);
            float a = float.Parse(altura.text);
            float operacion = ep / (g * a);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: ep / (g * a)";
            respuesta.text = "masa= " + operacion.ToString();
        }
        else if (graveda.text == "" && masa.text != "" && epotencial.text != "" && altura.text != "")
        {
            float m = float.Parse(masa.text);
            float ep = float.Parse(epotencial.text);
            float a = float.Parse(altura.text);
            float operacion = ep / (a * m);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: ep/(a*m)";
            respuesta.text = "gravedad= " + operacion.ToString();
        }
        else if (altura.text == "" && graveda.text != "" && masa.text != "" && epotencial.text != "")
        {
            float g = float.Parse(graveda.text);
            float m = float.Parse(masa.text);
            float ep = float.Parse(epotencial.text);
            float operacion = ep / (m * g);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: ep/(m*g)";
            respuesta.text = "altura= " + operacion.ToString();

        }
        else if (ecinetica.text == "" && masa.text != "" && velocidad.text != "")
        {
            float m = float.Parse(masa.text);
            float v = float.Parse(velocidad.text);
            double operacion = (1 / 2) * (m * (Math.Pow(v, 2)));
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(1/2)*m*(v^2)";
            respuesta.text = "energia cinetica= " + operacion.ToString();
        }
        else if (velocidad.text == "" && ecinetica.text != "" && masa.text != "")
        {
            float ec = float.Parse(ecinetica.text);
            float m = float.Parse(masa.text);
            double operacion = Math.Sqrt((ec * 2) / m);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:√(ec*2)/m)";
            respuesta.text = "velocidad= " + operacion.ToString();
        }
        else if (masa.text == "" && velocidad.text != "" && ecinetica.text != "")
        {
            float v = float.Parse(velocidad.text);
            float ec = float.Parse(ecinetica.text);
            double operacion = (ec * 2) / Math.Pow(v, 2);
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(ec*2)/v^2";
            respuesta.text = "masa= " + operacion.ToString();

        }
        else if (fuerzaroce.text == "" && coeficienteroce.text != "" && fuerzanormal.text != "")
        {
            float cf = float.Parse(coeficienteroce.text);
            float n = float.Parse(fuerzanormal.text);
            float operacion = cf * n;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: cf*n";
            respuesta.text = "fuerza de roce= " + operacion.ToString();
        }
        else if (coeficienteroce.text == "" && fuerzaroce.text != "" && fuerzanormal.text != "")
        {
            float fr = float.Parse(fuerzaroce.text);
            float n = float.Parse(fuerzanormal.text);
            float operacion = fr / n;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:fr/n";
            respuesta.text = "coeficiente de roce= " + operacion.ToString();
        }
        else if (fuerzanormal.text == "" && fuerzaroce.text != "" && coeficienteroce.text != "")
        {
            float u = float.Parse(coeficienteroce.text);
            float fr = float.Parse(fuerzaroce.text);
            float operacion = fr / u;
            ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:fr/u";
            respuesta.text = "fuerca de roce= " + operacion.ToString();
        }

        else {
            respuesta.text = "No hay suficientes datos para calcular alguna variable";
        }

    }



  
}
