using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
    
{
    Timer timer;
    GameObject player;
    public GameObject bullet;
    bool isAttacking = false;
    Vector3 pos;
    Vector3 playerpos;
    bool shoot = false;
   
    Rigidbody rb;
    Vector3 result;
    // Start is called before the first frame update
    void Start()
    {
       
        player = GameObject.FindWithTag("Player");
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 5;
        timer.Run();
        

    }

    // Update is called once per frame
    void Update()
    {
        pos = gameObject.transform.position;
        playerpos = player.transform.position;

        result = new Vector3((pos.x - playerpos.x), (pos.y - playerpos.y), (pos.z - playerpos.z));

        if (timer.elapsedSeconds >= 2)
        {
            GameObject newProjectile = Instantiate(bullet, transform.position + transform.forward, transform.rotation) as GameObject;
            //rb = newProjectile.GetComponent<Rigidbody>();
           // rb.AddForce(result, ForceMode.Impulse);
            timer.elapsedSeconds = 0;
        }
    }

  
   
}
