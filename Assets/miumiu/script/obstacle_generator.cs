using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_generator : MonoBehaviour
{
    public List<GameObject> obstacle_list = new List<GameObject>();

    GameObject obstacle;
    GameObject stage_A;
    GameObject stage_B;
    GameObject stage_C;
    GameObject stage_D;
    GameObject stage_E;
    GameObject stage_F;
    GameObject stage_G;
    GameObject stage_H;

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

        Pattern_generator(0, 0);
        Pattern_generator(Random.Range(1, 8), 10);
        Pattern_generator(Random.Range(1, 8), 20);
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Generator_obstacle();
    }

    void Pattern_generator(int pop_pattern, float z)
    {

        switch (pop_pattern)
        {
            case 0:
                obstacle = Instantiate(stage_A);
                
                break;
            case 1:
                obstacle = Instantiate(stage_B);

                break;
            case 2:
                obstacle = Instantiate(stage_C);

                break;
            case 3:
                obstacle = Instantiate(stage_D);

                break;
            case 4:
                obstacle = Instantiate(stage_E);

                break;
            case 5:
                obstacle = Instantiate(stage_F);

                break;
            case 6:
                obstacle = Instantiate(stage_G);

                break;
            case 7:
                obstacle = Instantiate(stage_H);

                break;
        }

        obstacle.transform.position = new Vector3(0f, 0f, z);

        obstacle_list.Add(obstacle);

    }

    void Generator_obstacle()
    {
        if (obstacle_list[0].transform.position.z <= -5f)
        {
            Pattern_generator(Random.Range(0, 8), obstacle_list[2].transform.position.z + 10f);
            obstacle_list.RemoveAt(0);
            Debug.Log(obstacle_list[2].transform.position.z);
        }
    }

}

