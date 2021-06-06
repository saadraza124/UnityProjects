using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    // Start is called before the first frame update
    public float spinSpeed=90;

    // Update is called once per frame
    void Update()
    {
       
     gameObject.transform.Rotate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * spinSpeed * Time.deltaTime);
        
    }
}
