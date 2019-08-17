using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    public GameObject OP1;
    public GameObject OP2;

    // Start is called before the first frame update
    void Start()
    {
        Color color = gameObject.GetComponent<Renderer>().material.color;
        color.a = 0.6f;

        gameObject.GetComponent<Renderer>().material.color = color;
    }
}

    
