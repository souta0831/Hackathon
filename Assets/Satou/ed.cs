using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    bool mouse = false;

    // 初期化
    void Start()
    {
        
    }
    void Update()
    {
        if (mouse == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mouse = true;
                GameObject obj = (GameObject)Resources.Load("Canvas");

                // プレハブを元にオブジェクトを生成する
                GameObject instance = (GameObject)Instantiate(obj,
                                                              new Vector3(0.0f, 0.0f, 0.0f),
                                                              Quaternion.identity);
            }
        }
    }
}