using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStartScript : MonoBehaviour
{
    float speed_default = 7.0f;
    float speed_fast = 8.0f;
    float speed_slow = 5.0f;
    float tmp_ball_velocity;
    int i_speed;
    float speed;
    Vector3 force_0 = new Vector3(0.0f, 10f, 0.0f);
    GameObject cubebottom;
    CubebottomScript cubebottomscript;
    bool SetBall;
    Vector3 PlayerPos;
    float tmp_y;

    Rigidbody myRigidbody;
    // Transformコンポーネントを保持しておくための変数を追加
    Transform myTransform;
    IEnumerator rest_velocity;
    IEnumerator rest_size;
    public GameObject Public_Player;


    void Start()
    {
        Public_Player = GameObject.Find("Player");
        Public_Player.transform.localScale = new Vector3(1.0f, 0.1f, 1);
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.velocity = new Vector3(0f, 0f, 0f);
        i_speed = 0;
        speed = velocity_function(i_speed, speed);
        myRigidbody.velocity = speed * myRigidbody.velocity.normalized;
        // Transformコンポーネントを取得して保持しておく
        myTransform = transform;
        
        cubebottom = GameObject.Find("Cubebottom");
        cubebottomscript = cubebottom.GetComponent<CubebottomScript>();
        SetBall = cubebottomscript.SetBall;
        tmp_y = myTransform.position.y;
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

    // Update is called once per frame
    void Update()
    {
        PlayerPos = Public_Player.transform.position;
        PlayerPos.y = tmp_y;

        if(SetBall)
        {
            if(Input.GetMouseButton(0))
            {
                Time.timeScale = 1f;
                PlayerPos.y = tmp_y;
                myTransform.position = PlayerPos;

            }
            if(Input.GetMouseButtonUp(0))
            {
                myRigidbody.isKinematic = false;
                myRigidbody.AddForce(force_0);
                SetBall = false;
            }
        }
    }
}
