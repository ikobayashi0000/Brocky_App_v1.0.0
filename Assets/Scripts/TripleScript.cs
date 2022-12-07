using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleScript : MonoBehaviour
{
    Rigidbody myRigidbody;
    GameObject ball;

    void Start()
    {
        ball = (GameObject)Resources.Load("BallPrefab");
        myRigidbody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Triple"))
        {
            CreateBall();
            CreateBall();
        }
    }

    void CreateBall()
    {
        Vector3 tmp = myRigidbody.transform.position;
        float speed = myRigidbody.velocity.magnitude;
        GameObject ball_clone = Instantiate(ball, tmp, Quaternion.identity);
    }
}