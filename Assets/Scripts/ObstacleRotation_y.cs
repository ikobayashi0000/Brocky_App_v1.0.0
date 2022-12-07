using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotation_y : MonoBehaviour
{
    // Start is called before the first frame update
    Transform myTransform;
    public bool bool_rotateblock;
    void Start()
    {
        if (bool_rotateblock == true)
        {
            myTransform = this.transform;
            myTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime, Space.Self);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (bool_rotateblock == true)
        {
            myTransform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime, Space.Self);
        }
    }
}
