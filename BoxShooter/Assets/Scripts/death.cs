using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    GameManager gm;
    GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindWithTag("Manager").GetComponent<GameManager>();
        bullet = GameObject.FindWithTag("EnemyShoot");
        
        
        

        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= -2.9) gm.EndGame();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyShoot") gm.EndGame();
    }

}
