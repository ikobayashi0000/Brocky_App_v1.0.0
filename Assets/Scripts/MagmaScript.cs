using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagmaScript : MonoBehaviour
{
    GameObject cubebottom;
    CubebottomScript cubebottomScript;
    Rigidbody myrigidbody;
    void Start()
    {
        myrigidbody = this.GetComponent<Rigidbody>();
        cubebottom = GameObject.Find("Cubebottom");
    }

    void Update()
    {
        float speed = myrigidbody.velocity.magnitude;
        Vector3 v = myrigidbody.velocity.normalized;

        if(speed >= 5.0f)
        {
            myrigidbody.velocity = v * 5.0f;
        }

        float ypos = this.transform.position.y;

        if(ypos < -4.4f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        string objName = collision.gameObject.name;

        if(collision.gameObject.CompareTag("Player"))
        {
            cubebottomScript = cubebottom.GetComponent<CubebottomScript>();
            cubebottomScript.heartcount -= 1;
            Destroy(this.gameObject);
            return;
        }
        else if(collision.gameObject.CompareTag("Ball"))
        {
            Destroy(this.gameObject);
        }
    }
}