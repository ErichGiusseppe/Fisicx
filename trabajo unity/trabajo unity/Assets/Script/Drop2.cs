using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop2 : MonoBehaviour
{
    private Animator buttonAnim;
    private B_ b_;
    void Start()
    {
        buttonAnim = GetComponent<Animator>();
        b_ = GameObject.Find("Code").GetComponent<B_>();
    }
    void Update()
    {
        if (b_.shovMenu)
            buttonAnim.SetBool("sop", true);
        if (!b_.shovMenu)
            buttonAnim.SetBool("sop", false);
    }
}