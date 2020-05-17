using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_ : MonoBehaviour
{
    public bool shovMenu;
    public void ButtonShovMenu()
    {
        if (!shovMenu)
            shovMenu = true;
        else if (shovMenu)
            shovMenu = false;

    }
}
