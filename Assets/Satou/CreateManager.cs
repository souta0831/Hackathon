using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ed : MonoBehaviour
{
    public GameObject ed3;

    // Start is called before the first frame update
    void Start()
    {
        //ed3.SetActive(false);
    }

    // Update is called once per frame
    void Update()   
    {       
        if (Input.GetMouseButtonDown(0))
        {
            ed3.SetActive(true);
            ed3.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        }
    }
}
