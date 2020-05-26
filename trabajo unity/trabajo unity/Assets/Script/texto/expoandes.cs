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


    public void Funciones()
    {
        int veces = 0;
        int cuantas_ecuaciones = 0;
        List<int> comprobacion = new List<int> ();
        
        while (veces < 28)
        {
            bool velocidadfinales = comprobacion.Contains(1);
            bool velocidadiniciales = comprobacion.Contains(2);
            bool gravedades = comprobacion.Contains(3);
            bool tiemposs = comprobacion.Contains(4);
            bool posicionesy= comprobacion.Contains(5);
            bool energiapotenciales =  comprobacion.Contains(6);
            bool masas  = comprobacion.Contains(7);
            bool alturas = comprobacion.Contains(8);
            bool energiacineticas  = comprobacion.Contains(9);
            bool velocidades = comprobacion.Contains(10);
            bool fuerzasroces = comprobacion.Contains(11);
            bool coeficientesroces = comprobacion.Contains(12);
            bool fuerzasnormales = comprobacion.Contains(13);
            veces = veces + 1;
            if (velocidadfinal.text == "" && velocidadinicial.text != "" && graveda.text != "" && tiempo.text != "" && velocidadfinales == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float VelocidadInicial = float.Parse(velocidadinicial.text);
                float Gravedad = float.Parse(graveda.text);
                float Tiempo = float.Parse(tiempo.text);
                comprobacion.Add(1);
                float operacion = VelocidadInicial + (Gravedad * Tiempo);

                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ",Vi+(g*t)";
                    respuesta.text = respuesta.text + " , velocidad final= " + operacion.ToString();
                    velocidadfinal.text = operacion.ToString();

                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:Vi+(g*t)";
                    respuesta.text = "velocidad final= " + operacion.ToString();
                    velocidadfinal.text = operacion.ToString();
                }

            }
            else if (velocidadfinal.text == "" && velocidadinicial.text != "" && graveda.text != "" && posiciony.text != "" && velocidadfinales == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float velocidad_inicial = float.Parse(velocidadinicial.text);
                float gravedad = float.Parse(graveda.text);
                float y = float.Parse(posiciony.text);
                comprobacion.Add(1);
                double result = Math.Sqrt(Math.Pow(velocidad_inicial, 2) + ((2 * gravedad) * y));
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (√v^2)+((2*g)*y) ";
                    respuesta.text = respuesta.text + " velocidad final= " + result.ToString();
                    velocidadfinal.text = result.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(√v^2)+((2*g)*y)";
                    respuesta.text = "velocidad final= " + result.ToString();
                    velocidadfinal.text = result.ToString();
                }

            }
            else if (velocidadfinal.text == "" && velocidadinicial.text != "" && posiciony.text != "" && tiempo.text != "" && velocidadfinales == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float velocidad_inicial = float.Parse(velocidadinicial.text);
                float y = float.Parse(posiciony.text);
                float Tiempo = float.Parse(tiempo.text);
                comprobacion.Add(1);
                double res = ((y * 2) / Tiempo) - velocidad_inicial;
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", ((y*2)/t)-Vi";
                    respuesta.text = respuesta.text + " velocidad final= " + res.ToString();
                    velocidadfinal.text = res.ToString();

                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:((y*2)/t)-Vi";
                    respuesta.text = "velocidad final= " + res.ToString();
                    velocidadfinal.text = res.ToString();
                }



            }
            else if (velocidadinicial.text == "" && velocidadfinal.text != "" && graveda.text != "" && tiempo.text != "" && velocidadiniciales == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float velocidad_final = float.Parse(velocidadfinal.text);
                comprobacion.Add(2);
                float gravedad = float.Parse(graveda.text);
                float Tiempo = float.Parse(tiempo.text);
                float respuestas = velocidad_final / (gravedad * Tiempo);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", Vf/(g*t)";
                    respuesta.text = respuesta.text + " velocidad inicial= " + respuestas.ToString();
                    velocidadinicial.text = respuestas.ToString();

                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:Vf/(g*t)";
                    respuesta.text = "velocidad inicial= " + respuestas.ToString();
                    velocidadinicial.text = respuestas.ToString();
                }
            }
            else if (velocidadinicial.text == "" && graveda.text != "" && tiempo.text != "" && posiciony.text != "" && velocidadiniciales == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float gravedad = float.Parse(graveda.text);
                float Tiempo = float.Parse(tiempo.text);
                float y = float.Parse(posiciony.text);
                comprobacion.Add(2);
                double respuestas = (y - (((1 / 2) * gravedad) * Math.Pow(Tiempo, 2))) / Tiempo;
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (y-(((1/2)*g)*(t^2/t)";
                    respuesta.text = respuesta.text + " velocidad inicial= " + respuestas.ToString();
                    velocidadinicial.text = respuestas.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(y-(((1/2)*g)*(t^2/t)";
                    respuesta.text = "velocidad inicial= " + respuestas.ToString();
                    velocidadinicial.text = respuestas.ToString();
                }

            }
            else if (velocidadinicial.text == "" && velocidadfinal.text != "" && posiciony.text != "" && graveda.text != "" && velocidadiniciales == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;

                float velocidad_final = float.Parse(velocidadfinal.text);
                float y = float.Parse(posiciony.text);
                float gravedad = float.Parse(graveda.text);
                comprobacion.Add(2);
                double respuestas = Math.Sqrt(velocidad_final - ((2 * gravedad) * y));
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", √(Vf-((2*g)*y)";
                    respuesta.text = respuesta.text + " velocidad inicial= " + respuestas.ToString();
                    velocidadinicial.text = respuestas.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:√(Vf-((2*g)*y)";
                    respuesta.text = "velocidad inicial= " + respuestas.ToString();
                    velocidadinicial.text = respuestas.ToString();
                }

            }
            else if (velocidadinicial.text == "" && velocidadfinal.text != "" && posiciony.text != "" && tiempo.text != "" && velocidadiniciales == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float velocidad_final = float.Parse(velocidadfinal.text);
                float y = float.Parse(posiciony.text);
                float Tiempo = float.Parse(tiempo.text);
                comprobacion.Add(2);
                double respuestas = ((y * 2) / Tiempo) - velocidad_final;
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", ((2*y)/t)-Vf";
                    respuesta.text = respuesta.text + " velocidad inicial= " + respuestas.ToString();
                    velocidadinicial.text = respuestas.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:((2*y)/t)-Vf";
                    respuesta.text = "velocidad inicial= " + respuestas.ToString();
                    velocidadinicial.text = respuestas.ToString();
                }

            }
            else if (graveda.text != "" && velocidadfinal.text != "" && velocidadinicial.text != "" && tiempo.text != "" && gravedades == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float velocidad_final = float.Parse(velocidadfinal.text);
                comprobacion.Add(3);
                float velocidad_inicial = float.Parse(velocidadinicial.text);
                float tiempos = float.Parse(tiempo.text);
                float respuestas = (velocidad_final - velocidad_inicial) / tiempos;
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (Vf-Vi)/t";
                    respuesta.text = respuesta.text + " gravedad= " + respuestas.ToString();
                    graveda.text = respuestas.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(Vf-Vi)/t";
                    respuesta.text = "gravedad= " + respuestas.ToString();
                    graveda.text = respuestas.ToString();
                }

            }
            else if (tiempo.text == "" && velocidadfinal.text != "" && velocidadinicial.text != "" && graveda.text != "" && tiemposs == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float velocidadf = float.Parse(velocidadfinal.text);
                float velocidadi = float.Parse(velocidadinicial.text);
                float gravedad = float.Parse(graveda.text);
                float respuestas = (velocidadf - velocidadi) / gravedad;
                comprobacion.Add(4);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (Vf-Vi)/g";
                    respuesta.text = respuesta.text + " tiempo= " + respuestas.ToString();
                    tiempo.text = respuestas.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(Vf-Vi)/g";
                    respuesta.text = "tiempo= " + respuestas.ToString();
                    tiempo.text = respuestas.ToString();
                }

            }
            else if (posiciony.text == "" && velocidadinicial.text != "" && tiempo.text != "" && graveda.text != "" && posicionesy == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1; 
                float vi = float.Parse(velocidadinicial.text);
                float tie = float.Parse(tiempo.text);
                float grav = float.Parse(graveda.text);
                double respuestas = (vi * tie) + (((1 / 2) * grav) * Math.Pow(tie, 2));
                comprobacion.Add(5);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (Vi*t)+(((1/2)*g)*t^2)";
                    respuesta.text = respuesta.text + " posicion en y= " + respuestas.ToString();
                    posiciony.text = respuestas.ToString();

                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(Vi*t)+(((1/2)*g)*t^2)";
                    respuesta.text = "posicion en y= " + respuestas.ToString();
                    posiciony.text = respuestas.ToString();

                }
                

            }
            else if (graveda.text == "" && posiciony.text != "" && velocidadinicial.text != "" && tiempo.text != "" && gravedades == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float y = float.Parse(posiciony.text);
                float vi = float.Parse(velocidadinicial.text);
                float tie = float.Parse(tiempo.text);
                comprobacion.Add(3);
                double respuestas = (2 * (y - (vi * tie))) / Math.Pow(tie, 2);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (2*(y-(Vi*t)))/t^2";
                    respuesta.text = respuesta.text + " gravedad= " + respuestas.ToString();
                    graveda.text = respuestas.ToString();
                }
                else
                {
                    graveda.text = respuestas.ToString();
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(2*(y-(Vi*t)))/t^2";
                    respuesta.text = "gravedad= " + respuestas.ToString();
                }
                

            }
            else if (posiciony.text != "" && velocidadfinal.text != "" && velocidadinicial.text != "" && graveda.text != "" && posicionesy == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float vi = float.Parse(velocidadinicial.text);
                float vf = float.Parse(velocidadfinal.text);
                float gra = float.Parse(graveda.text);
                comprobacion.Add(5);
                double respuestas = (Math.Pow(vf, 2) - Math.Pow(vi, 2)) / (2 * gra);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (Vf^2-Vi^2)(2*g)";
                    respuesta.text = respuesta.text + " posicion en y" + respuestas.ToString();
                    posiciony.text = respuestas.ToString();

                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(Vf^2-Vi^2)(2*g)";
                    respuesta.text = "posicion en y" + respuestas.ToString();
                    posiciony.text = respuestas.ToString();
                }

            }
            else if (graveda.text == "" && velocidadfinal.text != "" && velocidadinicial.text != "" && posiciony.text != "" && gravedades == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float vf = float.Parse(velocidadfinal.text);
                comprobacion.Add(3);
                float vi = float.Parse(velocidadinicial.text);
                float y = float.Parse(posiciony.text);
                double respuestas = (Math.Pow(vf, 2) - Math.Pow(vi, 2)) / (2 * y);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (Vf^2-Vi^2)/(2*y)";
                    respuesta.text = respuesta.text + " gravedad= " + respuestas.ToString();
                    graveda.text = respuestas.ToString();

                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(Vf^2-Vi^2)/(2*y)";
                    respuesta.text = "gravedad= " + respuestas.ToString();
                    graveda.text = respuestas.ToString();
                }
                

            }
            else if (posiciony.text == "" && velocidadinicial.text != "" && velocidadfinal.text != "" && tiempo.text != "" && posicionesy == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float vi = float.Parse(velocidadinicial.text);
                float vf = float.Parse(velocidadfinal.text);
                float tie = float.Parse(tiempo.text);
                comprobacion.Add(5);
                float respuestas = ((vi + vf) / 2);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", ((Vi+Vf)/2)";
                    respuesta.text = respuesta.text + " posicion en y= " + respuestas.ToString();
                    posiciony.text = respuestas.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:((Vi+Vf)/2)";
                    respuesta.text = "posicion en y= " + respuestas.ToString();
                    posiciony.text = respuestas.ToString();
                }
                
            }
            else if (tiempo.text != "" && posiciony.text != "" && velocidadinicial.text != "" && velocidadfinal.text != "" && tiemposs == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float y = float.Parse(posiciony.text);
                comprobacion.Add(4);
                float vi = float.Parse(velocidadinicial.text);
                float vf = float.Parse(velocidadfinal.text);
                float respuesats = (2 * y) / (vi + vf);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (2*y)/(Vi+Vf)";
                    respuesta.text =respuesta.text + " tiempo= " + respuesats.ToString();
                    tiempo.text = respuesats.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(2*y)/(Vi+Vf)";
                    respuesta.text = "tiempo= " + respuesats.ToString();
                    tiempo.text = respuesats.ToString();
                }
                

            }
            else if (tiempo.text == "" && velocidadfinal.text != "" && velocidadinicial.text != "" && posiciony.text != "" && graveda.text != "" && tiemposs == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float vf = float.Parse(velocidadfinal.text);
                float vi = float.Parse(velocidadinicial.text);
                float y = float.Parse(posiciony.text);
                comprobacion.Add(4);
                float gra = float.Parse(graveda.text);
                float respuestas = (y - vi) / ((1 / 2) * gra);
                if (cuantas_ecuaciones >1)
                {
                    ecuacion.text = ecuacion.text + ", (y-Vi)/((1/2)*g)";
                    respuesta.text = respuesta.text + " tiempo= " + respuestas.ToString();
                    tiempo.text = respuestas.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(y-Vi)/((1/2)*g)";
                    respuesta.text = "tiempo= " + respuestas.ToString();
                    tiempo.text = respuestas.ToString();
                }
                
            }
            else if (epotencial.text == "" && masa.text != "" && graveda.text != "" && altura.text != "" && energiapotenciales == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float m = float.Parse(masa.text);
                comprobacion.Add(6);
                float g = float.Parse(graveda.text);
                float a = float.Parse(altura.text);
                float operacion = m * g * a;
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (m)*(g)*(a)";
                    respuesta.text =respuesta.text + " Energia potencial= " + operacion.ToString();
                    epotencial.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(m)*(g)*(a)";
                    respuesta.text = "Energia potencial= " + operacion.ToString();
                    epotencial.text = operacion.ToString();
                }
                

            }
            else if (masa.text == "" && graveda.text != "" && epotencial.text != "" && altura.text != "" && masas == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float g = float.Parse(graveda.text);
                float ep = float.Parse(epotencial.text);
                float a = float.Parse(altura.text);
                float operacion = ep / (g * a);
                comprobacion.Add(7);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", ep / (g * a)";
                    respuesta.text = respuesta.text + " masa= " + operacion.ToString();
                    masa.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: ep / (g * a)";
                    respuesta.text = "masa= " + operacion.ToString();
                    masa.text = operacion.ToString();
                }
                
            }
            else if (graveda.text == "" && masa.text != "" && epotencial.text != "" && altura.text != "" && gravedades == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float m = float.Parse(masa.text);
                float ep = float.Parse(epotencial.text);
                comprobacion.Add(3);
                float a = float.Parse(altura.text);
                float operacion = ep / (a * m);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", ep/(a*m)";
                    respuesta.text =respuesta.text+ " gravedad= " + operacion.ToString();
                    graveda.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: ep/(a*m)";
                    respuesta.text = "gravedad= " + operacion.ToString();
                    graveda.text = operacion.ToString();
                }
                
            }
            else if (graveda.text == "" && masa.text != "" && epotencial.text != "" && altura.text != "" && gravedades == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float m = float.Parse(masa.text);
                float ep = float.Parse(epotencial.text);
                comprobacion.Add(3);
                float a = float.Parse(altura.text);
                float operacion = ep / (a * m);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ". ep/(a*m)";
                    respuesta.text = respuesta.text + " gravedad= " + operacion.ToString();
                    graveda.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: ep/(a*m)";
                    respuesta.text = "gravedad= " + operacion.ToString();
                    graveda.text = operacion.ToString();
                }
                
            }
            else if (altura.text == "" && graveda.text != "" && masa.text != "" && epotencial.text != "" && alturas == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float g = float.Parse(graveda.text);
                float m = float.Parse(masa.text);
                comprobacion.Add(8);
                float ep = float.Parse(epotencial.text);
                float operacion = ep / (m * g);
                if ( cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", ep/(m*g)";
                    respuesta.text =respuesta.text + " altura= " + operacion.ToString();
                    altura.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: ep/(m*g)";
                    respuesta.text = "altura= " + operacion.ToString();
                    altura.text = operacion.ToString();
                }
                

            }

            else if (ecinetica.text == "" && masa.text != "" && velocidad.text != "" && energiacineticas == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float m = float.Parse(masa.text);
                comprobacion.Add(9);
                float v = float.Parse(velocidad.text);
                double operacion = (1 / 2) * (m * (Math.Pow(v, 2)));
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (1/2)*m*(v^2)";
                    respuesta.text =respuesta.text + " energia cinetica= " + operacion.ToString();
                    ecinetica.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(1/2)*m*(v^2)";
                    respuesta.text = "energia cinetica= " + operacion.ToString();
                    ecinetica.text = operacion.ToString();
                }
                
            }
            else if (velocidad.text == "" && ecinetica.text != "" && masa.text != "" && velocidades == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float ec = float.Parse(ecinetica.text);
                float m = float.Parse(masa.text);
                double operacion = Math.Sqrt((ec * 2) / m);
                comprobacion.Add(10);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", √(ec*2)/m)";
                    respuesta.text =respuesta.text + " velocidad= " + operacion.ToString();
                    velocidad.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:√(ec*2)/m)";
                    respuesta.text = "velocidad= " + operacion.ToString();
                    velocidad.text = operacion.ToString();
                }
                
            }
            else if (masa.text == "" && velocidad.text != "" && ecinetica.text != "" && masas == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float v = float.Parse(velocidad.text);
                comprobacion.Add(7);
                float ec = float.Parse(ecinetica.text);
                double operacion = (ec * 2) / Math.Pow(v, 2);
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", (ec*2)/v^2";
                    respuesta.text =respuesta.text + " masa= " + operacion.ToString();
                    masa.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:(ec*2)/v^2";
                    respuesta.text = "masa= " + operacion.ToString();
                    masa.text = operacion.ToString();
                }
                

            }
            else if (fuerzaroce.text == "" && coeficienteroce.text != "" && fuerzanormal.text != "" && fuerzasroces == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float cf = float.Parse(coeficienteroce.text);
                float n = float.Parse(fuerzanormal.text);
                comprobacion.Add(11);
                float operacion = cf * n;
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", cf*n";
                    respuesta.text = respuesta.text + " fuerza de roce= " + operacion.ToString();
                    fuerzaroce.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema: cf*n";
                    respuesta.text = "fuerza de roce= " + operacion.ToString();
                    fuerzaroce.text = operacion.ToString();
                }
                
            }
            else if (coeficienteroce.text == "" && fuerzaroce.text != "" && fuerzanormal.text != "" && coeficientesroces == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float fr = float.Parse(fuerzaroce.text);
                comprobacion.Add(12);
                float n = float.Parse(fuerzanormal.text);
                float operacion = fr / n;
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", fr/n";
                    respuesta.text =respuesta.text + " coeficiente de roce= " + operacion.ToString();
                    coeficienteroce.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:fr/n";
                    respuesta.text = "coeficiente de roce= " + operacion.ToString();
                    coeficienteroce.text = operacion.ToString();
                }
                
            }
            else if (fuerzanormal.text == "" && fuerzaroce.text != "" && coeficienteroce.text != "" && fuerzasnormales == false)
            {
                cuantas_ecuaciones = cuantas_ecuaciones + 1;
                float u = float.Parse(coeficienteroce.text);
                comprobacion.Add(13);
                float fr = float.Parse(fuerzaroce.text);
                float operacion = fr / u;
                if (cuantas_ecuaciones > 1)
                {
                    ecuacion.text = ecuacion.text + ", fr/u";
                    respuesta.text = respuesta.text + " fuerca de roce= " + operacion.ToString();
                    fuerzanormal.text = operacion.ToString();
                }
                else
                {
                    ecuacion.text = "Esta es la ecuacion necesaria para solucionar el problema:fr/u";
                    respuesta.text = "fuerca de roce= " + operacion.ToString();
                    fuerzanormal.text = operacion.ToString();
                }
                
            }
            else if (cuantas_ecuaciones == 0)
            {
                respuesta.text = "No hay suficientes datos para calcular alguna variable";
            }

        }
    } 
}
