using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCircle : MonoBehaviour
{
    // Start is called before the first frame update
    Transform myTransform;
    public float range;
    public float centerx;
    public float centery;
    public float theta;
    public float speed;
    void Start()
    {
        myTransform = this.transform;
        myTransform.position = new Vector3(range * Mathf.Sin(speed * Time.time + theta * Mathf.PI/180f) + centerx, range * Mathf.Cos(speed * Time.time + theta* Mathf.PI/180f) + centery, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = new Vector3(range * Mathf.Sin(speed * Time.time + theta* Mathf.PI/180f) + centerx, range * Mathf.Cos(speed * Time.time + theta* Mathf.PI/180f) + centery, 0f);
    }
}
