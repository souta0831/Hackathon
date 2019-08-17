﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleTouch : MonoBehaviour
{
    [SerializeField]
    GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

#if UNITY_EDITOR

        if (Input.GetMouseButtonDown(0)) Instantiate(obj);


#else
        if (Input.touchCount > 0)   Instantiate(obj);

      
#endif

    }
}