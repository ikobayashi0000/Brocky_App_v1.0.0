using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationScript : MonoBehaviour
{
    Rigidbody myRigidbody;
    private IEnumerator St;
    // Update is called once per frame


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Acceleration"))
        {
            myRigidbody = GetComponent<Rigidbody>();
            float newspeed = 10.0f;
            Vector3 direction = myRigidbody.velocity.normalized;
            myRigidbody.velocity = newspeed * direction;
        }
    }
}