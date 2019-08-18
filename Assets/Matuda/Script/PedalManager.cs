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
    private float _start_speed = 10;
    [SerializeField]
    private float _max_speed=100;
    [SerializeField]
    private float _flame_par_down_speed = 0.1f;
    [SerializeField]
    float AddSpeed=10;
    [SerializeField]
    private PedarState _start_pedar;
    [SerializeField]
    GameManager _game_manager;
    private float _now_speed;

    private PedarState _now_Pedar = PedarState.R;

    void Start()
    { 
        _now_speed = _start_speed;
    }

    // Update is called once per fram
    void Update()
    {

        _now_speed -= _flame_par_down_speed;
        _now_speed=Mathf.Min(_now_speed, _max_speed);
        _now_speed = Mathf.Max(_now_speed, 0);

        //
        if (_game_manager.gameState == GameState.GAMEOVER) _now_speed = 0;

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

    public void OnAddSpeed()
    {
        _now_speed += AddSpeed;
        ChangeState();
        //押せるボタンを変更する

    }

    public float GetNowSpeed(){ return _now_speed;}

    public float GetMaxSpeed() { return _max_speed; }

    public PedarState GetNowPedar() { return _now_Pedar; }

    public PedarState GetStartPedar() { return _start_pedar; }
}
