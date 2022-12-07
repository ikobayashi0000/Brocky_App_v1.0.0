using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHorizon : MonoBehaviour
{
    // Start is called before the first frame update
    Transform myTransform;
    public float theta;
    public float obstacle_height;

    void Start()
    {
        myTransform = this.transform;
        myTransform.position = new Vector3(1.8f * Mathf.Sin(Time.time+ theta * Mathf.PI/180f), obstacle_height, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = new Vector3(1.8f * Mathf.Sin(Time.time+ theta * Mathf.PI/180f), obstacle_height, 0f);
    }
}