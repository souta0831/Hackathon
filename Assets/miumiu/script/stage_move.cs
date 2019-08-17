using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage_move : MonoBehaviour
{
    GameObject speed_manager;
    PedalManager pedal_script;
    float stage_speed;
    // Start is called before the first frame update
    void Start()
    {
        speed_manager = GameObject.Find("SpeedManager");
        pedal_script = speed_manager.GetComponent<PedalManager>();
    }

    // Update is called once per frame
    void Update()
    {
        pedal_script.GetNowSpeed();
        stage_speed = pedal_script._now_speed / 1000;
        transform.position -= transform.forward * stage_speed; //new Vector3(0f, 0f, stage_speed);

        if (transform.position.z <= -10f)
        {
            Destroy(gameObject);
        }
    }
}
