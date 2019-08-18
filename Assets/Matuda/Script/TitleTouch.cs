using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleTouch : MonoBehaviour
{
    [SerializeField]
    GameObject obj;
    private bool IsTap = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!IsTap)
        {
#if UNITY_EDITOR

            if (Input.GetMouseButtonDown(0)) Instantiate(obj);


#else
        if (Input.touchCount > 0)   Instantiate(obj);

      
#endif
            IsTap = true;
        }

    }
}
