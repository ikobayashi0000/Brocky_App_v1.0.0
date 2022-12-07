using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagmaUpScript : MonoBehaviour
{
    float timeElapsed;
    float interval = 2.0f;

    void Start()
    {
        Rigidbody MagmaRigid = gameObject.GetComponent<Rigidbody>();
        MagmaRigid.isKinematic = true;
    }

    void Update()
    {
        Rigidbody MagmaRigid = gameObject.GetComponent<Rigidbody>();
        timeElapsed += Time.deltaTime;
        if(timeElapsed >= interval)
        {
            float power = Random.Range(200.0f, 300.0f);
            Vector3 force = new Vector3(0.0f, power, 0.0f);
            MagmaRigid.isKinematic = false;
            MagmaRigid.AddForce(force, ForceMode.Impulse);
            timeElapsed = 0.0f;
        }
    }
}