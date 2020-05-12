using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class creacion : MonoBehaviour
{
    //Name Input Field

    public GameObject sap;
    public GameObject BolaAcero;
    public GameObject BolaCaucho;
    public GameObject BolaMadera;
    public GameObject BolaVidrio;
    public GameObject BolaPiedra;
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
    public Material Caucho;
    public Material Acero;
    public Material Vidrio;
    public Material Piedra;
    public Material Madera;
    public Material Ceramica;
    public Material Blanco;
    public Material Verde;
    public Material Azul;
    public Material Rojo;
    public string Bolas;
    public string Bolas2;
    public bool bola2 = false;
    public bool bola1 = false;


    public void Objeto_statik()
    {
        float valor_en_X1 = (float.Parse(posicionX1.text))+ 3326f;
        float valor_en_X2 = (float.Parse(posicionX2.text))+ 3326f;
        float valor_en_Y1 = (float.Parse(posicionY1.text));
        float valor_en_Y2 = (float.Parse(posicionY2.text));
        float valor_en_Z1 = (float.Parse(posicionZ1.text)) -613f;
        float valor_en_Z2 = (float.Parse(posicionZ2.text)) -613f;
        if (valor_en_X1 > 7133f)
        {
            valor_en_X1 = 7133f;
        }
        if (valor_en_X1 < 3426f)
        {
            valor_en_X1 = 3426f;
        }
        if (valor_en_X2 > 7133f)
        {
            valor_en_X2 = 7133f;
        }
        if (valor_en_X2 < 3426f)
        {
            valor_en_X2 = 3426f;
        }

        Bolas = Bola.text;
        Bolas2 = Bola1.text;
        if ((Bolas.ToLower()) == ("caucho"))
        {
            GameObject copy_bolae_caucho = Instantiate(BolaCaucho);
            copy_bolae_caucho.transform.position = new Vector3(float.Parse(posicionX1.text), float.Parse(posicionY1.text), float.Parse(posicionZ1.text));
            copy_bolae_caucho.GetComponent<Renderer>().material = Caucho;
            bola1 = true;
        }
        if ((Bolas.ToLower()) == ("acero"))
        {
            GameObject copy_bolaacero = Instantiate(BolaAcero);
            copy_bolaacero.transform.position = new Vector3(float.Parse(posicionX1.text), float.Parse(posicionY1.text), float.Parse(posicionZ1.text));
            copy_bolaacero.GetComponent<Renderer>().material = Acero;
            bola1 = true;
        }
        if ((Bolas.ToLower()) == ("piedra"))
        {
            GameObject copy_bolapiedra = Instantiate(BolaPiedra);
            copy_bolapiedra.transform.position = new Vector3(float.Parse(posicionX1.text), float.Parse(posicionY1.text), float.Parse(posicionZ1.text));
            copy_bolapiedra.GetComponent<Renderer>().material = Acero;
            bola1 = true;
        }
        if ((Bolas.ToLower()) == ("madera"))
        {
            GameObject copy_bolamadera = Instantiate(BolaMadera);
            copy_bolamadera.transform.position = new Vector3(float.Parse(posicionX1.text), float.Parse(posicionY1.text), float.Parse(posicionZ1.text));
            copy_bolamadera.GetComponent<Renderer>().material = Acero;
            bola1 = true;
        }
        if ((Bolas.ToLower()) == ("vidrio"))
        {
            GameObject copy_bolavidrio = Instantiate(BolaVidrio);
            copy_bolavidrio.transform.position = new Vector3(float.Parse(posicionX1.text), float.Parse(posicionY1.text), float.Parse(posicionZ1.text));
            copy_bolavidrio.GetComponent<Renderer>().material = Acero;
            bola1 = true;
        }
        if (((float.Parse(velocidadX1.text) != 0f)) && (bola1 == true))
        {
            GameObject Flecha1_c = Instantiate(Flecha1x);
            Flecha1_c.transform.position = new Vector3(float.Parse(posicionX1.text) - 55f, float.Parse(posicionY1.text), (float.Parse(posicionZ1.text)) + 15f);

            if (float.Parse(velocidadX1.text) > 0f)
            {
                Flecha1_c.transform.position = new Vector3(float.Parse(posicionX1.text) + 55f, float.Parse(posicionY1.text), (float.Parse(posicionZ1.text)) + 15f);
                Flecha1_c.transform.Rotate(new Vector3(0f, 180f, 0f));
            }
        }

        if (((float.Parse(velocidadY1.text)) != 0f) && (bola1 == true))
        {
            GameObject Flecha2_c = Instantiate(Flecha2y);
            if (float.Parse(velocidadY1.text) > 0f)
            {
                Flecha2_c.transform.position = new Vector3(float.Parse(posicionX1.text) - 25f, (float.Parse(posicionY1.text)) + 100f, (float.Parse(posicionZ1.text) - 10f));
                Flecha2_c.transform.Rotate(new Vector3(0f, 90f, -90f));

            }
            if (float.Parse(velocidadY1.text) < 0f)
            {
                Flecha2_c.transform.position = new Vector3(float.Parse(posicionX1.text) - 35f, (float.Parse(posicionY1.text)) - 90f, (float.Parse(posicionZ1.text) - 10f));
                Flecha2_c.transform.Rotate(new Vector3(0f, 90f, 90f));

            }
        }
        if (((float.Parse(velocidadZ1.text)) != 0f));
        {
            GameObject Flecha3_c = Instantiate(Flecha3z);

            if (float.Parse(velocidadZ1.text) > 0f)
            {
                Flecha3_c.transform.position = new Vector3(float.Parse(posicionX1.text) - 30f, float.Parse(posicionY1.text), (float.Parse(posicionZ1.text)) + 70f);
                Flecha3_c.transform.Rotate(new Vector3(0f, 90f, 0f));

            }
            if (float.Parse(velocidadZ1.text) < 0f)
            {
                Flecha3_c.transform.position = new Vector3(float.Parse(posicionX1.text) - 30f, float.Parse(posicionY1.text), (float.Parse(posicionZ1.text)) - 70f);
                Flecha3_c.transform.Rotate(new Vector3(0f, -90f, 0f));

            }

        }
        if ((Bolas2.ToLower()) == ("caucho"))
        {
            GameObject copy_bolae_caucho = Instantiate(BolaCaucho);
            copy_bolae_caucho.transform.position = new Vector3(float.Parse(posicionX2.text), float.Parse(posicionY2.text), float.Parse(posicionZ2.text));
            copy_bolae_caucho.GetComponent<Renderer>().material = Caucho;
            bola2 = true;
        }
        if ((Bolas2.ToLower()) == ("acero"))
        {
            GameObject copy_bolaacero = Instantiate(BolaAcero);
            copy_bolaacero.transform.position = new Vector3(float.Parse(posicionX2.text), float.Parse(posicionY2.text), float.Parse(posicionZ2.text));
            copy_bolaacero.GetComponent<Renderer>().material = Acero;
            bola2 = true;
        }
        if ((Bolas2.ToLower()) == ("piedra"))
        {
            GameObject copy_bolapiedra = Instantiate(BolaPiedra);
            copy_bolapiedra.transform.position = new Vector3(float.Parse(posicionX2.text), float.Parse(posicionY2.text), float.Parse(posicionZ2.text));
            copy_bolapiedra.GetComponent<Renderer>().material = Acero;
            bola2 = true;
        }
        if ((Bolas2.ToLower()) == ("madera"))
        {
            GameObject copy_bolamadera = Instantiate(BolaMadera);
            copy_bolamadera.transform.position = new Vector3(float.Parse(posicionX2.text), float.Parse(posicionY2.text), float.Parse(posicionZ2.text));
            copy_bolamadera.GetComponent<Renderer>().material = Acero;
            bola2 = true;
        }
        if ((Bolas2.ToLower()) == ("vidrio"))
        {
            GameObject copy_bolavidrio = Instantiate(BolaVidrio);
            copy_bolavidrio.transform.position = new Vector3(float.Parse(posicionX2.text), float.Parse(posicionY2.text), float.Parse(posicionZ2.text));
            copy_bolavidrio.GetComponent<Renderer>().material = Acero;
            bola2 = true;
        }
        if (((float.Parse(velocidadX2.text)) != 0f)&&(bola2 == true))
        {
            GameObject Flecha1_c = Instantiate(Flecha1x);
            Flecha1_c.transform.position = new Vector3(float.Parse(posicionX2.text) - 55f, float.Parse(posicionY2.text), (float.Parse(posicionZ2.text)) + 15f);

            if (float.Parse(velocidadX2.text) > 0f)
            {
                Flecha1_c.transform.position = new Vector3(float.Parse(posicionX2.text) + 55f, float.Parse(posicionY2.text), (float.Parse(posicionZ2.text)) + 15f);
                Flecha1_c.transform.Rotate(new Vector3(0f, 180f, 0f));
            }
        }

        if (((float.Parse(velocidadY2.text)) != 0f) &&(bola2 == true))
        {
            GameObject Flecha2_c = Instantiate(Flecha2y);
            if (float.Parse(velocidadY2.text) > 0f)
            {
                Flecha2_c.transform.position = new Vector3(float.Parse(posicionX2.text) - 35f, (float.Parse(posicionY2.text)) + 90f, (float.Parse(posicionZ2.text) - 10f));
                Flecha2_c.transform.Rotate(new Vector3(0f, 90f, -90f));

            }
            if (float.Parse(velocidadY1.text) < 0f)
            {
                Flecha2_c.transform.position = new Vector3(float.Parse(posicionX2.text) - 35f, (float.Parse(posicionY2.text)) - 90f, (float.Parse(posicionZ2.text) - 10f));
                Flecha2_c.transform.Rotate(new Vector3(0f, 90f, 90f));

            }
        }
        if (((float.Parse(velocidadZ2.text)) != 0f)&&(bola2 == true))
        {
            GameObject Flecha3_c = Instantiate(Flecha3z);
            if (float.Parse(velocidadZ2.text) > 0f)
            {
                Flecha3_c.transform.position = new Vector3(float.Parse(posicionX2.text) - 30f, float.Parse(posicionY2.text), (float.Parse(posicionZ2.text)) + 70f);
                Flecha3_c.transform.Rotate(new Vector3(0f, 90f, 0f));

            }
            if (float.Parse(velocidadZ1.text) < 0f)
            {
                Flecha3_c.transform.position = new Vector3(float.Parse(posicionX2.text) - 30f, float.Parse(posicionY2.text), (float.Parse(posicionZ2.text)) - 70f);
                Flecha3_c.transform.Rotate(new Vector3(0f, -90f, 0f));

            }
            Destroy(sap);
        }
    }
}
