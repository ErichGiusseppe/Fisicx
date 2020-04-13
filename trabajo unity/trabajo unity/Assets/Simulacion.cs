using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Simulacion : MonoBehaviour
{
    public GameObject bolaHierro;
    public GameObject bolaCaucho;
    public InputField velocidadX1;
    public InputField velocidadY1;
    public InputField posicionX1;
    public InputField posicionY1;
    public InputField posicionZ1;
    public InputField velocidadX2;
    public InputField velocidadY2;
    public InputField posicionX2;
    public InputField posicionY2;
    public InputField posicionZ2;
    public InputField masa1;
    public InputField masa2;
    public void simular()
    {
        if (posicionZ1.text != null && posicionZ1.text != "" && posicionX1.text != null && posicionX1.text != "" && posicionY1.text != null && posicionY1.text != "")
        {
            GameObject copia = Instantiate(bolaCaucho);
            copia.transform.position = new Vector3(float.Parse(posicionX1.text), float.Parse(posicionY1.text), float.Parse(posicionZ1.text));
            Rigidbody rigidBody = copia.GetComponent<Rigidbody>();
            rigidBody.mass = float.Parse("1");
            rigidBody.velocity = new Vector3(float.Parse(velocidadX1.text), float.Parse(velocidadY1.text), 0);
        }
        if(posicionZ2.text != null && posicionZ2.text != "" && posicionX2.text != null && posicionX2.text != "" && posicionY2.text != null && posicionY2.text != "")
        {
            GameObject copia2 = Instantiate(bolaCaucho);
            copia2.transform.position = new Vector3(float.Parse(posicionX2.text), float.Parse(posicionY2.text), float.Parse(posicionZ2.text));
            Rigidbody rigidBody2 = copia2.GetComponent<Rigidbody>();
            rigidBody2.mass = float.Parse("1");
            rigidBody2.velocity = new Vector3(float.Parse(velocidadX2.text), float.Parse(velocidadY2.text), 0);
        }
    }
}
