using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D3 : MonoBehaviour
{
    private Animator buttonAnim;
    private B_2 b_2;
    void Start()
    {
        buttonAnim = GetComponent<Animator>();
        b_2 = GameObject.Find("Code").GetComponent<B_2>();
    }
    void Update()
    {
        if (b_2.shovMenu)
            buttonAnim.SetBool("sep", true);
        if (!b_2.shovMenu)
            buttonAnim.SetBool("sep", false);
    }
}
