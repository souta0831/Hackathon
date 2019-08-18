using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public List<GameObject> obstacle_list = new List<GameObject> ();

    GameObject obstacle;
    GameObject stage_A;
    GameObject stage_B;
    GameObject stage_C;
    GameObject stage_D;
    GameObject stage_E;
    GameObject stage_F;
    GameObject stage_G;
    GameObject stage_H;
    GameObject stage_I;
    GameObject stage_J;

    int num = 10;

    // Start is called before the first frame update
    void Start ()
    {
        stage_A = (GameObject)Resources.Load ("StagePattern/StageA");
        stage_B = (GameObject)Resources.Load ("StagePattern/StageB");
        stage_C = (GameObject)Resources.Load ("StagePattern/StageC");
        stage_D = (GameObject)Resources.Load ("StagePattern/StageD");
        stage_E = (GameObject)Resources.Load ("StagePattern/StageE");
        stage_F = (GameObject)Resources.Load ("StagePattern/StageF");
        stage_G = (GameObject)Resources.Load ("StagePattern/StageG");
        stage_H = (GameObject)Resources.Load ("StagePattern/StageH");
        stage_I = (GameObject)Resources.Load ("StagePattern/StageI");
        stage_J = (GameObject)Resources.Load ("StagePattern/StageJ");

        Pattern_generator (0, 10);
        for (int i = 1 ; i < num ; i++)
        {
            Pattern_generator (Random.Range (1, 10), i * 10 + 10);
        }
    }

    // Update is called once per frame
    private void LateUpdate ()
    {
        Generator_obstacle ();
    }

    void Pattern_generator (int pop_pattern, float z)
    {

        switch (pop_pattern)
        {
        case 0:
            obstacle = Instantiate (stage_A);

            break;
        case 1:
            obstacle = Instantiate (stage_B);

            break;
        case 2:
            obstacle = Instantiate (stage_C);

            break;
        case 3:
            obstacle = Instantiate (stage_D);

            break;
        case 4:
            obstacle = Instantiate (stage_E);

            break;
        case 5:
            obstacle = Instantiate (stage_F);

            break;
        case 6:
            obstacle = Instantiate (stage_G);

            break;
        case 7:
            obstacle = Instantiate (stage_H);

            break;
        case 8:
            obstacle = Instantiate (stage_I);

            break;
        case 9:
            obstacle = Instantiate (stage_J);

            break;
        }

        obstacle.transform.position = new Vector3 (0f, 0f, z);

        obstacle_list.Add (obstacle);

    }

    void Generator_obstacle ()
    {
        if (obstacle_list[0].transform.position.z <= -5f)
        {
            Pattern_generator (Random.Range (0, 10), obstacle_list[num - 1].transform.position.z + 10f);
            obstacle_list.RemoveAt (0);
        }
    }

}
