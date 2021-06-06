//using System;
using System.Collections;
using System.Collections.Generic;
//using Unity.Mathematics;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [SerializeField]
    GameObject brick;
    [SerializeField]
    GameObject pickup;
    [SerializeField]
    GameObject Bonusbrick;
    Timer timer;
    float j = 4;
    int randomNo;
    // Start is called before the first frame update
    void Start()
    {
         randomNo = Random.Range(0,13);
        timer = gameObject.AddComponent<Timer>();
        for (int i = 0; i < 13; i++)
        {
            if(i==randomNo) Instantiate<GameObject>(Bonusbrick, new Vector2(-6 + i, j), Quaternion.identity);
            else Instantiate<GameObject>(brick, new Vector2(-6 + i, j), Quaternion.identity);

        }
        timer.Duration = 15;
        timer.Run();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.Finished)
        {
            randomNo = Random.Range(0, 13);
            j -= (float)0.5;
            for (int i = 0; i < 13; i++)
            {
                if (i == randomNo) Instantiate<GameObject>(Bonusbrick, new Vector2(-6 + i, j), Quaternion.identity);
                else Instantiate<GameObject>(brick, new Vector2(-6 + i, j), Quaternion.identity);
            }
            timer.Run();
        }
    }
}
