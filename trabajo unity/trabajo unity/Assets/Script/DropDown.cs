﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    private Animator buttonAnim;
    private Boton boton;
    void Start()
    {
        buttonAnim = GetComponent<Animator>();
        boton = GameObject.Find("Code").GetComponent<Boton>();
    }
    void Update()
    {
        if (boton.shovMenu)
            buttonAnim.SetBool("sap", true);
        if (!boton.shovMenu)
            buttonAnim.SetBool("sap", false);
    }
}
