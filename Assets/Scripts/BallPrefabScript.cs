using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

class BallPrefabScript : MonoBehaviour
{  
    float speed_default = 5.0f;
    float speed_fast = 7.0f;
    float speed_slow = 3.5f;
    float tmp_ball_velocity;
    int i_speed;
    float speed;

    IEnumerator rest_velocity;
    IEnumerator rest_size;
    Rigidbody myRigidbody;
    // Transformコンポーネントを保持しておくための変数を追加
    Transform myTransform;

    public AudioClip sePlayer;
    public AudioClip seBuff;
    public AudioClip seDebuff;
    public AudioClip seBlockC5;
    public AudioClip seBlockD;
    public AudioClip seBlockE;
    public AudioClip seBlockF;
    public AudioClip seBlockG;
    public AudioClip seBlockA;
    public AudioClip seBlockB;
    public AudioClip seBlockC6;
    public GameObject Public_Player;

    //int i_ballcollision = 0;
    void Start()
    {
        Public_Player = GameObject.Find("Player");
        float rnd_x = UnityEngine.Random.Range(-1.0f, 1.0f);
        float rnd_y = UnityEngine.Random.Range(-1.0f, 1.0f);
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.velocity = new Vector3(rnd_x, rnd_y, 0);
        myRigidbody.velocity = 5.0f * Mathf.Sqrt(2.0f) * myRigidbody.velocity.normalized;
        Vector3 force_0 = new Vector3(rnd_x, rnd_y, 0.0f);
        myRigidbody.AddForce(force_0);
        // Transformコンポーネントを取得して保持しておく
        myTransform = transform;
    }


    float velocity_function(int i, float abs_velocity)
    {
        if (i == 0)
        {
            abs_velocity = speed_default;
        }
        else if(i == 1)
        {
            abs_velocity = speed_fast;
        }
        else if(i == 2)
        {
            abs_velocity = speed_slow;
        }
        return abs_velocity;
    }

}