using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BasicMover : MonoBehaviour
{   public enum motionDirection {Horizontal, Vertical, Spin};
    public motionDirection MotionState = motionDirection.Horizontal;
    public float spinSpeed = 180f;
    public float motionSpeed = 0.1f;
    // Update is called once per frame
    void Update()
    {

        switch(MotionState)
        {
            case motionDirection.Horizontal:
                gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionSpeed);
                break;
            case motionDirection.Vertical:
                gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionSpeed);
                break;
            case motionDirection.Spin:
                gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
                break;
        }
        
    }
}
