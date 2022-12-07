using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public GameObject Public_Ball;
    float tmp_ball_velocity;

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}