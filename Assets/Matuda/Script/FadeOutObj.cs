using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutObj : MonoBehaviour
{
    private Image _image;
    [SerializeField]
    private float _out_speed=0.01f;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    private float end_alpha = 1.0f;
    private float _alpha = 0;
    private bool end_fanc_flag = false;
    //end_alphaまで行ったら生成するオブジェクト
    [SerializeField]
    private GameObject end_create_obj;
    void Start()
    {
        _image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_alpha >= end_alpha)
        {
            if(!end_fanc_flag)
            {
                Instantiate(end_create_obj);
                end_fanc_flag = true;
            }
            return;
        }
        _image.color = new Color(0, 0, 0, _alpha);
        _alpha += _out_speed;
    }
}
