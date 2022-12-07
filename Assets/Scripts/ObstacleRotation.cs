using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotation : MonoBehaviour
{
    // Start is called before the first frame update
    Transform myTransform;
    void Start()
    {
        myTransform = this.transform;
        myTransform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime, Space.Self);
    }
}
