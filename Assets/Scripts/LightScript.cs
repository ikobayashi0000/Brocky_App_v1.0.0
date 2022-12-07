using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{

    void FixedUpdate()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Ball");
        Transform myTransform = this.transform;
        Vector3 PlayerPos = player.transform.position;
        myTransform.position = PlayerPos;
    }
}
