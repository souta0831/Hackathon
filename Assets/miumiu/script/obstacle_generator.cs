using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_generator : MonoBehaviour
{
    public List<GameObject> pattern_list = new List<GameObject>();

    GameObject obstacle;
    GameObject stage_A;
    GameObject stage_B;
    GameObject stage_C;
    GameObject stage_D;
    GameObject stage_E;
    GameObject stage_F;
    GameObject stage_G;
    GameObject stage_H;

    int pop_pattern;

    // Start is called before the first frame update
    void Start()
    {
        stage_A = (GameObject)Resources.Load("stage_A");
        stage_B = (GameObject)Resources.Load("stage_B");
        stage_C = (GameObject)Resources.Load("stage_C");
        stage_D = (GameObject)Resources.Load("stage_D");
        stage_E = (GameObject)Resources.Load("stage_E");
        stage_F = (GameObject)Resources.Load("stage_F");
        stage_G = (GameObject)Resources.Load("stage_G");
        stage_H = (GameObject)Resources.Load("stage_H");

        pop_pattern = Random.Range(0, 7);
        Pattern_generator();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Pattern_generator()
    {
        switch (pop_pattern)
        {
            case 0:
                obstacle = Instantiate(stage_A, new Vector3(0f, 0f, 0f), transform.rotation);
                pattern_list.Add(obstacle);
                break;
            case 1:
                obstacle = Instantiate(stage_B, new Vector3(0f, 0f, 0f), transform.rotation);
                pattern_list.Add(obstacle);
                break;
            case 2:
                obstacle = Instantiate(stage_C, new Vector3(0f, 0f, 0f), transform.rotation);
                pattern_list.Add(obstacle);
                break;
            case 3:
                obstacle = Instantiate(stage_D, new Vector3(0f, 0f, 0f), transform.rotation);
                pattern_list.Add(obstacle);
                break;
            case 4:
                obstacle = Instantiate(stage_E, new Vector3(0f, 0f, 0f), transform.rotation);
                pattern_list.Add(obstacle);
                break;
            case 5:
                obstacle = Instantiate(stage_F, new Vector3(0f, 0f, 0f), transform.rotation);
                pattern_list.Add(obstacle);
                break;
            case 6:
                obstacle = Instantiate(stage_G, new Vector3(0f, 0f, 0f), transform.rotation);
                pattern_list.Add(obstacle);
                break;
            case 7:
                obstacle = Instantiate(stage_H, new Vector3(0f, 0f, 0f), transform.rotation);
                pattern_list.Add(obstacle);
                break;
        }
    }

}

