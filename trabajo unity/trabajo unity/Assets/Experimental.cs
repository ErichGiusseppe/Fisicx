using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Experimental : MonoBehaviour
{
public GameObject bolaVidrio;
public GameObject bolaCaucho;
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

 public void elastica()
 {
   GameObject copia = Instantiate(bolaCaucho);
    copia.transform.position = new Vector3(10*(float.Parse(posicionX1.text)),float.Parse(posicionY1.text),float.Parse(posicionZ1.text));
    Rigidbody rigidBody = copia.GetComponent<Rigidbody>();
    rigidBody.mass = float.Parse(masa1.text);
    rigidBody.velocity = new Vector3(10*(float.Parse(velocidadX1.text)), float.Parse(velocidadY1.text),float.Parse(velocidadZ1.text));
    GameObject copia2 = Instantiate(bolaCaucho);
    copia2.transform.position = new Vector3(10*(float.Parse(posicionX2.text)),float.Parse(posicionY2.text),float.Parse(posicionZ2.text));
    Rigidbody rigidBody2 = copia2.GetComponent<Rigidbody>();
    rigidBody2.mass = float.Parse(masa2.text);
    rigidBody2.velocity = new Vector3(10*(float.Parse(velocidadX2.text)), float.Parse(velocidadY2.text),float.Parse(velocidadZ2.text));
 }
 public void inElastica()
 {
   GameObject copia = Instantiate(bolaVidrio);
    copia.transform.position = new Vector3(10*(float.Parse(posicionX1.text)),float.Parse(posicionY1.text),float.Parse(posicionZ1.text));
    Rigidbody rigidBody = copia.GetComponent<Rigidbody>();
    rigidBody.mass = float.Parse(masa1.text);
    rigidBody.velocity = new Vector3(10*(float.Parse(velocidadX1.text)), float.Parse(velocidadY1.text),float.Parse(velocidadZ1.text));
    GameObject copia2 = Instantiate(bolaVidrio);
    copia2.transform.position = new Vector3(10*(float.Parse(posicionX2.text)),float.Parse(posicionY2.text),float.Parse(posicionZ2.text));
    Rigidbody rigidBody2 = copia2.GetComponent<Rigidbody>();
    rigidBody2.mass = float.Parse(masa2.text);
    rigidBody2.velocity = new Vector3(10*(float.Parse(velocidadX2.text)), float.Parse(velocidadY2.text),float.Parse(velocidadZ2.text));
 }
   public void cambiarEscenaPrincipal()
    {
        SceneManager.LoadScene("a");
    }
}
