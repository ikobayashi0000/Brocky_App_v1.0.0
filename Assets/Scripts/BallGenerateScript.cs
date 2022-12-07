using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerateScript : MonoBehaviour
{
    Rigidbody myRigidbody;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Acceleration"))
        {
            myRigidbody = GetComponent<Rigidbody>();
            Vector3 direction = myRigidbody.velocity;
            CreateBall();
            CreateBall();
        }
    }

    void CreateBall()
    {
        GameObject ball = (GameObject)Resources.Load("BallPrefab");
        GameObject ball_clone = Instantiate(ball, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        ball_clone.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
