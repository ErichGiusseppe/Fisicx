using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraP : MonoBehaviour
{
    public Camera Camara1;
    public Camera Camara2;
    public Camera CamP;
    public void Camara1ver()
    {
        Camara1.enabled = true;
        Camara2.enabled = false;
        CamP.enabled = false;
    }

    public void Camara2ver()
    {
        Camara1.enabled = false;
        Camara2.enabled = true;
        CamP.enabled = false;
    }
    public void CamaraPver()
    {
        Camara1.enabled = false;
        Camara2.enabled = false;
        CamP.enabled = true;
    }
}
