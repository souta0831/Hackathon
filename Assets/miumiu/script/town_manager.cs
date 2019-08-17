using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class town_manager : MonoBehaviour
{
    GameObject town;
    GameObject town_copy;
    // Start is called before the first frame update
    void Start()
    {
        town = (GameObject)Resources.Load("House");
        Generator_town(0);
        Pop_town(0f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Pop_town(50f);
    }

    void Generator_town(float POP_POINT)
    {
        town_copy = Instantiate(town);
        town_copy.transform.position = new Vector3(-32.5f, -13.6f, POP_POINT);
    }

    void Pop_town(float POP_TIMING)
    {
        if (town_copy.transform.position.z <= POP_TIMING)
        {
            Generator_town(town_copy.transform.position.z + 90f);
        }
    }
}
