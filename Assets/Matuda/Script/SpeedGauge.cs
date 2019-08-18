using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpeedGauge : MonoBehaviour
{
    //ゲージ
    Slider _slider;
    //管理クラス
    [SerializeField]
    private PedalManager _pedal_manager;

    private float _now_speed = 0;
    private float _max_speed = 0;

    void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue= _pedal_manager.GetMaxSpeed(); 
    }

    // Update is called once per frame
    void Update()
    {
        _now_speed = _pedal_manager.GetNowSpeed();
        _slider.value = _now_speed ;
    }
}
