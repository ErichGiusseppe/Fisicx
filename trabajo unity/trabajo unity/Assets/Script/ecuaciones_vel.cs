using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ecuaciones_vel : MonoBehaviour
{
    public InputField velocidadx;
    public InputField velocidady;
    public InputField velocidadz;
    public float xady;
    public float xop;
    public float xhip;
    public float yhip;
    public float yady;
    public float zhip;
    public float zop;
    public float zady;

    // Start is called before the first frame update
    void Start()
    {
        xady = float.Parse(velocidadx.text);
        zady = float.Parse(velocidadz.text);
        yady = float.Parse(velocidady.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
