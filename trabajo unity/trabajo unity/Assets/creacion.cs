using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class creacion: MonoBehaviour
{
    public GameObject BolaHierro;
    public GameObject BolaCaucho;
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
    public GameObject Flecha1;
    public GameObject Flecha2;


    public void Objeto_statik()
    {
        if ((ToLower(Bola.txt)) ==  ("BolaCaucho"));
        {
           GameObject copy_bolae_caucho = Instantiate(BolaCaucho);
           copy_bolae_caucho.transform.position = new Vector3(float.Parse(posicionX1.txt), float.Parse(posicionY1.txt), float.Parse(posicionZ1.txt));
           GameObject Flecha1_c = Instantiate(Flecha1);
           Flecha1_c.transform.position = new Vector3(float.Parse(posicionX1.txt), float.Parse(posicionY1.txt), float.Parse(posicionZ1.txt));
           Flecha1_c.transform.localScale = new Vector3(float.Parse(velocidadX1.txt), float.Parse(velocidadY1.txt), float.Parse(velocidadZ1));
        }
        if ((ToLower(Bola.txt)) == ("BolaHierro"));
        {
            GameObject copy_bolae_caucho = Instantiate(BolaHierro);
            copy_bolae_caucho.transform.position = new Vector3(float.Parse(posicionX1.txt), float.Parse(posicionY1.txt), float.Parse(posicionZ1.txt));
        }
        if ((ToLower(Bola1.txt)) == ("BolaCaucho")) ;
        {
            GameObject copy_bolae_caucho = Instantiate(BolaCaucho);
            copy_bolae_caucho.transform.position = new Vector3(float.Parse(posicionX1.txt), float.Parse(posicionY1.txt), float.Parse(posicionZ1.txt));

        }
        if ((ToLower(Bola1.txt)) == ("BolaHierro")) ;
        {
            GameObject copy_bolae_caucho = Instantiate(BolaHierro);
            copy_bolae_caucho.transform.position = new Vector3(float.Parse(posicionX1.txt), float.Parse(posicionY1.txt), float.Parse(posicionZ1.txt));
        }

    }
}
