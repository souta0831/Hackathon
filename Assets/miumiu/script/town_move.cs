using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class town_move : MonoBehaviour
{
    GameObject speed_manager;
    PedalManager pedal_script;
    float town_speed;
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
        town_speed = pedal_script.GetNowSpeed() / 1000;
        transform.position -= transform.forward * town_speed;

        if (transform.position.z <= -50f)
        {
            Destroy(gameObject);
        }
    }
}
