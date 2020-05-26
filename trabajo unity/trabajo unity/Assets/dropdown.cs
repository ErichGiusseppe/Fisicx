using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dawda : MonoBehaviour
{
    private Animator buttonAnim;
    private Boton boton;
    // Start is called before the first frame update
    void Start()
    {
        buttonAnim = GetComponent<Animator>();
        boton = GameObject.Find("Code").GetComponent<Boton>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boton.shovmenu)
        {
            buttonAnim.SetBool("Mostrar_visu", true);
        }

        if (!boton.shovmenu)
        {
            buttonAnim.SetBool("Mostrar_visu", false);
        }


    }
}
