using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecelerateScript : MonoBehaviour
{
    Rigidbody myRigidbody;
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)  
    {
        if(collision.gameObject.CompareTag("Deceleration"))
        {
            myRigidbody = GetComponent<Rigidbody>();
            float newspeed = 3.0f;
            Vector3 direction = myRigidbody.velocity.normalized;
            myRigidbody.velocity = newspeed * direction;
        }
    }
}