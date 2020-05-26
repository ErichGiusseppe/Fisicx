using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class creacion : MonoBehaviour
{
    public Camera Camara1;
    public Camera Camara2;
    public GameObject gravedad;
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
        Destroy(GameObject.Find("1"));
        Destroy(GameObject.Find("1"));
        Destroy(GameObject.Find("1"));
        Destroy(GameObject.Find("1"));
        Destroy(GameObject.Find("1"));
        Destroy(GameObject.Find("2"));
        Destroy(GameObject.Find("2"));
        Destroy(GameObject.Find("2"));
        Destroy(GameObject.Find("2"));
        Destroy(GameObject.Find("2"));
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
                GameObject copy_bolae_caucho = Instantiate(BolaCaucho);
                copy_bolae_caucho.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1);
                bola1 = true;
                copy_bolae_caucho.name = "1";
                Camara1.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1-30f);



            }
            if ((Bolas.ToLower()) == ("acero"))
            {
                GameObject copy_bolaacero = Instantiate(BolaAcero);
                copy_bolaacero.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1);
                bola1 = true;
                copy_bolaacero.name = "1";
                Camara1.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1 - 30f);
            }
            if ((Bolas.ToLower()) == ("piedra"))
            {
                GameObject copy_bolapiedra = Instantiate(BolaPiedra);
                copy_bolapiedra.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1);
                bola1 = true;
                copy_bolapiedra.name = "1";
                Camara1.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1 - 30f);
            }
            if ((Bolas.ToLower()) == ("madera"))
            {
                GameObject copy_bolamadera = Instantiate(BolaMadera);
                copy_bolamadera.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1);
                bola1 = true;
                copy_bolamadera.name = "1";
                Camara1.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1 - 30f);
            }
            if ((Bolas.ToLower()) == ("vidrio"))
            {
                GameObject copy_bolavidrio = Instantiate(BolaVidrio);
                copy_bolavidrio.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1);
                bola1 = true;
                copy_bolavidrio.name = "1";
                Camara1.transform.position = new Vector3(valor_en_X1, valor_en_Y1, valor_en_Z1 - 30f);
            }
            if (velocidadX1.text != "")
            {
                if (((float.Parse(velocidadX1.text) != 0f)) && (bola1 == true))
                {
                    GameObject Flecha1_c = Instantiate(Flecha1x);
                    Flecha1_c.transform.position = new Vector3(valor_en_X1 - 55f, valor_en_Y1, (valor_en_Z1) + 15f);
                    Flecha1_c.name = "1";

                    if (float.Parse(velocidadX1.text) > 0f)
                    {
                        Flecha1_c.transform.position = new Vector3(valor_en_X1 + 55f, valor_en_Y1, (valor_en_Z1) + 15f);
                        Flecha1_c.transform.Rotate(new Vector3(0f, 180f, 0f));

                    }
                }
            }
            if (velocidadY1.text != "")
            {
                if (((float.Parse(velocidadY1.text)) != 0f) && (bola1 == true))
                {
                    GameObject Flecha2_c = Instantiate(Flecha2y);
                    Flecha2_c.name = "1";
                    if (float.Parse(velocidadY1.text) > 0f)
                    {
                        Flecha2_c.transform.position = new Vector3(valor_en_X1 - 25f, (valor_en_Y1) + 100f, (valor_en_Z1 - 10f));
                        Flecha2_c.transform.Rotate(new Vector3(0f, 90f, -90f));

                    }
                    if (float.Parse(velocidadY1.text) < 0f)
                    {
                        Flecha2_c.transform.position = new Vector3(valor_en_X1 - 35f, (valor_en_Y1) - 90f, (valor_en_Z1 - 10f));
                        Flecha2_c.transform.Rotate(new Vector3(0f, 90f, 90f));

                    }
                }
            }
            if (velocidadZ1.text != "")
            {
                if (((float.Parse(velocidadZ1.text)) != 0f) && (bola1 == true))
                {
                    GameObject Flecha3_c = Instantiate(Flecha3z);
                    Flecha3_c.name = "1";

                    if (float.Parse(velocidadZ1.text) > 0f)
                    {
                        Flecha3_c.transform.position = new Vector3(valor_en_X1 - 30f, valor_en_Y1, (valor_en_Z1) + 70f);
                        Flecha3_c.transform.Rotate(new Vector3(0f, 90f, 0f));

                    }
                    if (float.Parse(velocidadZ1.text) < 0f)
                    {
                        Flecha3_c.transform.position = new Vector3(valor_en_X1 - 30f, float.Parse(posicionY1.text), (valor_en_Z1) - 70f);
                        Flecha3_c.transform.Rotate(new Vector3(0f, -90f, 0f));

                    }

                }
            }
            GameObject grav1 = Instantiate(gravedad);
            grav1.name = "2";
            grav1.transform.position = new Vector3(valor_en_X1 - 35f, (valor_en_Y1) - 90f, (valor_en_Z1 - 10f));
            grav1.transform.Rotate(new Vector3(0f, 90f, 90f));
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
                GameObject copy_bolae_caucho = Instantiate(BolaCaucho);
                copy_bolae_caucho.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2);
                copy_bolae_caucho.GetComponent<Renderer>().material = Caucho;
                bola2 = true;
                copy_bolae_caucho.name = "2";
                Camara2.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2-30f);
            }
            if ((Bolas2.ToLower()) == ("acero"))
            {
                GameObject copy_bolaacero = Instantiate(BolaAcero);
                copy_bolaacero.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2);
                bola2 = true;
                copy_bolaacero.name = "2";
                Camara2.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2-30f);
            }
            if ((Bolas2.ToLower()) == ("piedra"))
            {
                GameObject copy_bolapiedra = Instantiate(BolaPiedra);
                copy_bolapiedra.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2);
                bola2 = true;
                copy_bolapiedra.name = "2";
                Camara2.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2-30f);
            }
            if ((Bolas2.ToLower()) == ("madera"))
            {
                GameObject copy_bolamadera = Instantiate(BolaMadera);
                copy_bolamadera.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2);
                bola2 = true;
                copy_bolamadera.name = "2";
                Camara2.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2 - 30f);
            }
            if ((Bolas2.ToLower()) == ("vidrio"))
            {
                GameObject copy_bolavidrio = Instantiate(BolaVidrio);
                copy_bolavidrio.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2);
                bola2 = true;
                copy_bolavidrio.name = "2";
                Camara2.transform.position = new Vector3(valor_en_X2, valor_en_Y2, valor_en_Z2 - 30f);
            }
            if (velocidadX2.text != "")
            {
                if (((float.Parse(velocidadX2.text)) != 0f) && (bola2 == true))
                {
                    GameObject Flecha1_c = Instantiate(Flecha1x);
                    Flecha1_c.transform.position = new Vector3(valor_en_X2 - 55f, valor_en_Y2, (valor_en_Z2) + 15f);
                    Flecha1_c.name = "2";

                    if (float.Parse(velocidadX2.text) > 0f)
                    {
                        Flecha1_c.transform.position = new Vector3(valor_en_X2 + 55f, valor_en_Y2, (valor_en_Z2) + 15f);
                        Flecha1_c.transform.Rotate(new Vector3(0f, 180f, 0f));
                    }
                }
            }
            if (velocidadY2.text != "")
            {
                if (((float.Parse(velocidadY2.text)) != 0f) && (bola2 == true))
                {
                    GameObject Flecha2_c = Instantiate(Flecha2y);
                    Flecha2_c.name = "2";
                    if (float.Parse(velocidadY2.text) > 0f)
                    {
                        Flecha2_c.transform.position = new Vector3(valor_en_X2 - 35f, (valor_en_Y2) + 90f, (valor_en_Z2 - 10f));
                        Flecha2_c.transform.Rotate(new Vector3(0f, 90f, -90f));

                    }
                    if (float.Parse(velocidadY1.text) < 0f)
                    {
                        Flecha2_c.transform.position = new Vector3(valor_en_X2 - 35f, (valor_en_Y2) - 90f, (valor_en_Z2 - 10f));
                        Flecha2_c.transform.Rotate(new Vector3(0f, 90f, 90f));

                    }
                }
            }
            if (velocidadZ2.text != "")
            {
                if (((float.Parse(velocidadZ2.text)) != 0f) && (bola2 == true))
                {
                    GameObject Flecha3_c = Instantiate(Flecha3z);
                    Flecha3_c.name = "2";
                    if (float.Parse(velocidadZ2.text) > 0f)
                    {
                        Flecha3_c.transform.position = new Vector3(valor_en_X2 - 30f, valor_en_Y2, (valor_en_Z2) + 70f);
                        Flecha3_c.transform.Rotate(new Vector3(0f, 90f, 0f));

                    }
                    if (float.Parse(velocidadZ1.text) < 0f)
                    {
                        Flecha3_c.transform.position = new Vector3(valor_en_X2 - 30f, valor_en_Y2, (valor_en_Z2) - 70f);
                        Flecha3_c.transform.Rotate(new Vector3(0f, -90f, 0f));

                    }
                }
            }
            GameObject grav2 = Instantiate(gravedad);
            grav2.name = "2";
            grav2.transform.position = new Vector3(valor_en_X2 - 35f, (valor_en_Y2) - 90f, (valor_en_Z2 - 10f));
            grav2.transform.Rotate(new Vector3(0f, 90f, 90f));

           

        }
    }
}
