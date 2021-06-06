using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    Vector2 spawnLocationMin;
    Vector2 spawnLocationMax;
    Timer timer;
    int random;
    bool retrySpawn = true;
    // Start is called before the first frame update
    void Awake()
    {
        QualitySettings.vSyncCount = 0;  // VSync must be disabled
        Application.targetFrameRate = 60;
        timer = gameObject.AddComponent<Timer>();
    }
    void Start()
    {
        random = (int)Random.Range(ConfigurationUtils.MinSpawnTime, ConfigurationUtils.MaxSpawnTime+1);
        timer.Duration = random;
        timer.Run();


        GameObject tempBall = Instantiate<GameObject>(ball);
        BoxCollider2D collider = tempBall.GetComponent<BoxCollider2D>();
        float ballColliderHalfWidth = collider.size.x / 2;
        float ballColliderHalfHeight = collider.size.y / 2;
        spawnLocationMin = new Vector2(
            tempBall.transform.position.x - ballColliderHalfWidth,
            tempBall.transform.position.y - ballColliderHalfHeight);
        spawnLocationMax = new Vector2(
            tempBall.transform.position.x + ballColliderHalfWidth,
            tempBall.transform.position.y + ballColliderHalfHeight);
        Destroy(tempBall);

    }

    // Update is called once per frame
    void Update()
    {
      
           // print(HUD.ballsLeftcount);

            if (timer.Finished)
            {

            
                if (HUD.ballsLeftcount > 0)
                {
                HUD.ballsLeftcount--;
                print(HUD.ballsLeftcount);              
                ballSpawner();
                    HUD.count++;
                    

                    print("ball spawned");
                    random = (int)Random.Range(ConfigurationUtils.MinSpawnTime, ConfigurationUtils.MaxSpawnTime + 1);
                    timer.Duration = random;
                    timer.Run();
                }
            
            }     
        
    }
    public void ballSpawner()
    {
        
        
            Instantiate<GameObject>(ball);
           
        
    }
    public bool checkOverlap() {
        if (Physics2D.OverlapArea(spawnLocationMin, spawnLocationMax) == null) return true;
        else return false;
    }

 
}
