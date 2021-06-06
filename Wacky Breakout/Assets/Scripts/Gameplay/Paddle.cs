using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D bc;
    float halfColliderWidth;
    const float  BounceAngleHalfRange= 60 * Mathf.Deg2Rad;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        halfColliderWidth = bc.size.x/2 ;     
    }

    private void FixedUpdate()
    {
        
        if (Input.GetAxis("Horizontal") != 0)
        {
            Vector3 pos = gameObject.transform.position;
            pos.x += Input.GetAxis("Horizontal")*ConfigurationUtils.PaddleMoveUnitsPerSecond;
            rb.MovePosition(new Vector2(pos.x, 0));
        }
    }
    private void Update()
    {
        clamped();
    }

    void clamped() {

        Vector2 pos = gameObject.transform.position;
        if (pos.x < ScreenUtils.ScreenLeft + halfColliderWidth) pos.x = ScreenUtils.ScreenLeft + halfColliderWidth;
        if (pos.x > ScreenUtils.ScreenRight - halfColliderWidth) pos.x = ScreenUtils.ScreenRight - halfColliderWidth;
        gameObject.transform.position = pos;
        }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball"))
        {
            // calculate new ball direction
            float ballOffsetFromPaddleCenter = transform.position.x -
                coll.transform.position.x;
            float normalizedBallOffset = ballOffsetFromPaddleCenter /
                halfColliderWidth;
            float angleOffset = normalizedBallOffset * BounceAngleHalfRange;
            float angle = Mathf.PI / 2 + angleOffset;
            Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

            // tell ball to set direction to new direction
            Ball ballScript = coll.gameObject.GetComponent<Ball>();
            ballScript.SetDirection(direction);
        }
    }


}