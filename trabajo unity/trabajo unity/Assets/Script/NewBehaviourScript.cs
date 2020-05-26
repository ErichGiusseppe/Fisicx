﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public Camera Camara1;
    public Camera Camara2;
    public GameObject BolaAceromov;
    public GameObject BolaCauchomov;
    public GameObject BolaMaderamov;
    public GameObject BolaVidriomov;
    public GameObject BolaPiedramov;
    public InputField velocidadX1;
    public InputField velocidadY1;
    public InputField velocidadZ1;
    public InputField posicionX1;
    public InputField posicionY1;
    public InputField posicionZ1;
    public InputField velocidadX2;
    public InputField velocidadY2;
    public InputField velocidadZ2;
    public InputField posicionX2;
    public InputField posicionY2;
    public InputField posicionZ2;
    public InputField masa1;
    public InputField masa2;
    public InputField Bola;
    public InputField Bola1;
    public GameObject Flecha1x;
    public GameObject Flecha2y;
    public GameObject Flecha3z;
    public string Bolas;
    public string Bolas2;
    public bool bola2 = false;
    public bool bola1 = false;
    private float valor_en_X1;
    private float valor_en_X2;
    private float valor_en_Y1;
    private float valor_en_Y2;
    private float valor_en_Z1;
    private float valor_en_Z2;


    public void Objeto_statik()
    {

        Destroy(GameObject.Find("1"));
        Destroy(GameObject.Find("2"));
        Bolas = Bola.text;
        Bolas2 = Bola1.text;
        if (Bolas != "")
        {
            if (posicionX1.text != "")
            {
                valor_en_X1 = float.Parse(posicionX1.text) + 3426f;
                if (valor_en_X1 > 6506f)
                {
                    valor_en_X1 = 6506f;
                }
                if (valor_en_X1 < 3426f)
                {
                    valor_en_X1 = 3426f;
                }
            }
            else
            {
                valor_en_X1 = 0f;
            }
            if (posicionY1.text != "")
            {
                valor_en_Y1 = float.Parse(posicionY1.text) - 60f;
                if (valor_en_Y1 < 1741f)
                {
                    valor_en_Y1 = 1741f;
                }
                if (valor_en_Y1 < -10f)
                {
                    valor_en_Y1 = -10f;
                }
            }
            else
            {
                valor_en_Y1 = 0f;
            }
            if (posicionZ1.text != "")
            {
                valor_en_Z1 = float.Parse(posicionZ1.text) - 613f;
                if (valor_en_Z1 > 2385f)
                {
                    valor_en_Z1 = 2385f;
                }
                if (valor_en_Z1 < -81f)
                {
                    valor_en_Z1 = -81f;
                }
            }
            else
            {
                valor_en_Z1 = 0f;
            }
            if ((Bolas.ToLower()) == ("caucho"))
            {
                GameObject copy_bolae_caucho = Instantiate(BolaCauchomov);
                copy_bolae_caucho.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1);
                bola1 = true;
                Rigidbody rigidBody2 = copy_bolae_caucho.GetComponent<Rigidbody>();
                rigidBody2.mass = float.Parse(masa1.text);
                rigidBody2.velocity = new Vector3(float.Parse(velocidadX1.text), float.Parse(velocidadY1.text), float.Parse(velocidadY1.text));
                copy_bolae_caucho.name = "1";
            }
            if ((Bolas.ToLower()) == ("acero"))
            {
                GameObject copy_bolaacero = Instantiate(BolaAceromov);
                copy_bolaacero.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1);
                bola1 = true;
                Rigidbody rigidBodya = copy_bolaacero.GetComponent<Rigidbody>();
                rigidBodya.mass = float.Parse(masa1.text);
                rigidBodya.velocity = new Vector3(float.Parse(velocidadX1.text), float.Parse(velocidadY1.text), float.Parse(velocidadY1.text));
                copy_bolaacero.name = "1";
            }
            if ((Bolas.ToLower()) == ("piedra"))
            {
                GameObject copy_bolapiedra = Instantiate(BolaPiedramov);
                copy_bolapiedra.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1);
                bola1 = true;
                Rigidbody rigidBodyp = copy_bolapiedra.GetComponent<Rigidbody>();
                rigidBodyp.mass = float.Parse(masa1.text);
                rigidBodyp.velocity = new Vector3(float.Parse(velocidadX1.text), float.Parse(velocidadY1.text), float.Parse(velocidadY1.text));
                copy_bolapiedra.name = "1";
            }
            if ((Bolas.ToLower()) == ("madera"))
            {
                GameObject copy_bolamadera = Instantiate(BolaMaderamov);
                copy_bolamadera.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1);
                bola1 = true;
                Rigidbody rigidBodyma = copy_bolamadera.GetComponent<Rigidbody>();
                rigidBodyma.mass = float.Parse(masa1.text);
                rigidBodyma.velocity = new Vector3(float.Parse(velocidadX1.text), float.Parse(velocidadY1.text), float.Parse(velocidadY1.text));
                copy_bolamadera.name = "1";
            }
            if ((Bolas.ToLower()) == ("vidrio"))
            {
                GameObject copy_bolavidrio = Instantiate(BolaVidriomov);
                copy_bolavidrio.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1);
                bola1 = true;
                Rigidbody rigidBodyvid = copy_bolavidrio.GetComponent<Rigidbody>();
                rigidBodyvid.mass = float.Parse(masa1.text);
                rigidBodyvid.velocity = new Vector3(float.Parse(velocidadX1.text), float.Parse(velocidadY1.text), float.Parse(velocidadY1.text));
                copy_bolavidrio.name = "1";
            }
        }
        if (Bolas2 != "")
        {
            if (posicionX2.text != "")
            {
                valor_en_X2 = float.Parse(posicionX2.text) + 3326f;
                if (valor_en_X2 > 6506f)
                {
                    valor_en_X2 = 6506f;
                }
                if (valor_en_X2 < 3426f)
                {
                    valor_en_X2 = 3426f;
                }
            }
            else
            {
                valor_en_X2 = 0f;
            }
            if (posicionY2.text != "")
            {
                valor_en_Y2 = float.Parse(posicionY2.text) - 60f;
                if (valor_en_Y2 < 1741f) 
                {
                    valor_en_Y2 = 1741f;
                }
                if (valor_en_Y2 < -10f)
                {
                    valor_en_Y2 = -10f;
                }
            }
            else
            {
                valor_en_Y1 = 0f;
            }

            if (posicionZ2.text != "")
            {
                valor_en_Z2 = float.Parse(posicionZ2.text) - 613f;
                if (valor_en_Z2 < 2385f)
                {
                    valor_en_Z2 = 2385f;
                }
                if (valor_en_Z2 < -81f)
                {
                    valor_en_Z2 = -81f;
                }
            }
            else
            {
                valor_en_Z2 = 0f;
            }
            if ((Bolas2.ToLower()) == ("caucho"))
            {
                GameObject copy_bolae_caucho = Instantiate(BolaCauchomov);
                copy_bolae_caucho.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2);
                bola2 = true;
                Rigidbody rigidBodyvid = copy_bolae_caucho.GetComponent<Rigidbody>();
                rigidBodyvid.mass = float.Parse(masa2.text);
                rigidBodyvid.velocity = new Vector3(float.Parse(velocidadX2.text), float.Parse(velocidadY2.text), float.Parse(velocidadY2.text));
                copy_bolae_caucho.name = "2";
            }
            if ((Bolas2.ToLower()) == ("acero"))
            {
                GameObject copy_bolaacero = Instantiate(BolaAceromov);
                copy_bolaacero.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2);
                bola2 = true;
                Rigidbody rigidBodyac = copy_bolaacero.GetComponent<Rigidbody>();
                rigidBodyac.mass = float.Parse(masa2.text);
                rigidBodyac.velocity = new Vector3(float.Parse(velocidadX2.text), float.Parse(velocidadY2.text), float.Parse(velocidadY2.text));
                copy_bolaacero.name = "2";
            }
            if ((Bolas2.ToLower()) == ("piedra"))
            {
                GameObject copy_bolapiedra = Instantiate(BolaPiedramov);
                copy_bolapiedra.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2);
                bola2 = true;
                Rigidbody rigidBodypi = copy_bolapiedra.GetComponent<Rigidbody>();
                rigidBodypi.mass = float.Parse(masa2.text);
                rigidBodypi.velocity = new Vector3(float.Parse(velocidadX2.text), float.Parse(velocidadY2.text), float.Parse(velocidadY2.text));
                copy_bolapiedra.name = "2";
            }
            if ((Bolas2.ToLower()) == ("madera"))
            {
                GameObject copy_bolamadera = Instantiate(BolaMaderamov);
                copy_bolamadera.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2);
                bola2 = true;
                Rigidbody rigidBodyma = copy_bolamadera.GetComponent<Rigidbody>();
                rigidBodyma.mass = float.Parse(masa2.text);
                rigidBodyma.velocity = new Vector3(float.Parse(velocidadX2.text) + 500f, float.Parse(velocidadY2.text), float.Parse(velocidadY2.text));
                copy_bolamadera.name = "2";
            }
            if ((Bolas2.ToLower()) == ("vidrio"))
            {
                GameObject copy_bolavidrio = Instantiate(BolaVidriomov);
                copy_bolavidrio.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2);
                bola2 = true;
                Rigidbody rigidBodyvidrio = copy_bolavidrio.GetComponent<Rigidbody>();
                rigidBodyvidrio.mass = float.Parse(masa2.text);
                rigidBodyvidrio.velocity = new Vector3(float.Parse(velocidadX2.text) + 500f, float.Parse(velocidadY2.text), float.Parse(velocidadY2.text));
                copy_bolavidrio.name = "2";
            }
        }
        //Camara.transform.position = new Vector3(float.Parse(posicionX1.text) + 500f, (float.Parse(posicionY1.text)-10f), (float.Parse(posicionZ1.text))-300f);
    }
}
