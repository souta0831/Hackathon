using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PedarState
{
    R, L
}

public class PedalManager : MonoBehaviour
{
    //[System.NonSerialized]
    [SerializeField]
    private float _now_speed;
    [SerializeField]
    private float _start_speed = 10;
    [SerializeField]
    private float _max_speed=100;

    [SerializeField]
    Slider _hp_gauge;

    [SerializeField]
    float AddSpeed=10;

    private PedarState _now_Pedar = PedarState.R;

    void Start()
    {
        _now_speed = _start_speed;
        _hp_gauge = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        _now_speed -= 0.1f;
        Mathf.Min(_now_speed, _max_speed);
    }
    public void RightPedalButton()
    {
        if (PedarState.R == _now_Pedar)
        {
            AddPedar();
        }
    }

    public void LeftPedalButton()
    {
        if (PedarState.L == _now_Pedar)
        {
            AddPedar();
        }
    }


    void AddPedar()
    {
        _now_speed += AddSpeed;
        ChangeState();
        //押せるボタンを変更する

    }
   void ChangeState()
    {
        if (_now_Pedar == PedarState.R)
        {
            _now_Pedar = PedarState.L;
        }
        else
        {
            _now_Pedar = PedarState.R;

        }
    }

    public float GetNowSpeed(){ return _now_speed;}

    public float GetMaxSpeed() { return _max_speed; }
}
