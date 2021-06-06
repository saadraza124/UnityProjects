using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    BallSpawner spawner;
    Rigidbody2D rb;
    CircleCollider2D cd;
    Vector2 direction;
    Timer timer;
    Timer timer1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cd = GetComponent<CircleCollider2D>();
        spawner = Camera.main.GetComponent<BallSpawner>();
        
        float rad = Mathf.Deg2Rad * 270;
        direction = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
      
        //ConfigurationUtils.BallImpulseForce
        timer = gameObject.AddComponent<Timer>();
        timer1 = gameObject.AddComponent<Timer>();
        timer1.Duration = 1;
        timer.Duration = ConfigurationUtils.BallLifetime;
        //timer.Run();
        timer1.Run();
       // rb.AddForce(direction * ConfigurationUtils.BallImpulseForce, ForceMode2D.Impulse);
    }

    private void Update()
    {
        if (timer1.Finished) { rb.AddForce(direction * ConfigurationUtils.BallImpulseForce, ForceMode2D.Impulse);
           timer.Run();
            timer1.stop();
        }
        
        if (timer.Finished)
        {
            //timer.Run();
            // spawner.ballSpawner();
            HUD.count--;
            Destroy(gameObject);
            
        }
        if (transform.position.y < GameObject.FindGameObjectWithTag("Player").transform.position.y-1) { spawner.ballSpawner(); Destroy(gameObject); }
    }


   
    


    public void SetDirection(Vector2 direction) {
        //rb.AddForce(direction * ConfigurationUtils.BallImpulseForce, ForceMode2D.Impulse);

        rb.velocity = rb.velocity.magnitude * direction;
    }
  
}
