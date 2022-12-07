using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallScript : MonoBehaviour
{
    float speed_default = 7.0f;
    float speed_fast = 8.0f;
    float speed_slow = 5.0f;
    float tmp_ball_velocity;
    int i_speed;
    float speed;
    Vector3 force_0 = new Vector3(0.0f, 10.0f, 0.0f);
    GameObject cubebottom;
    CubebottomScript cubebottomscript;
    GameObject savedata;
    SaveDataScript savedatascript;
    bool SetBall;
    Vector3 PlayerPos;
    float tmp_y;

    Rigidbody myRigidbody;
    // Transformコンポーネントを保持しておくための変数を追加
    Transform myTransform;
    IEnumerator rest_velocity;
    IEnumerator rest_size;

    AudioSource audioSource;
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
    float SeVolume;
    //SaveDatascript SaveDatascript ;

    //int i_ballcollision = 0;

    void Start()
    {
        Public_Player = GameObject.Find("Player");
        myRigidbody = GetComponent<Rigidbody>();        
        myRigidbody.velocity = new Vector3(0f, 0f, 0f);
        i_speed = 0;
        speed = velocity_function(i_speed, speed);
        myRigidbody.velocity = speed * myRigidbody.velocity.normalized;
        // Transformコンポーネントを取得して保持しておく
        myTransform = transform;
        savedata = GameObject.Find("SaveData");
        savedatascript = savedata.GetComponent<SaveDataScript>();
        audioSource = GetComponent<AudioSource>();

        tmp_y = myTransform.position.y;
    }

    void Update()
    {
        
        Vector3 velocity = myRigidbody.velocity;
        speed = velocity_function(i_speed, speed);
        myRigidbody.velocity = speed * myRigidbody.velocity.normalized;

        float tan_velocity = myRigidbody.velocity.y/myRigidbody.velocity.x;
        if (Mathf.Abs(tan_velocity) < 0.05f)
        {
            Vector3 force = new Vector3 (0.0f, -Mathf.Sign(myTransform.position.y)*2f, 0.0f);    // 力を設定
            myRigidbody.AddForce (force);  // 力を加える
        }
        else if (Mathf.Abs(tan_velocity) > 20.0f & Mathf.Abs(myTransform.position.x) > 2.18f)
        {
            Vector3 force = new Vector3 (-Mathf.Sign(myTransform.position.x)*2f, 0.0f, 0.0f);    // 力を設定
            myRigidbody.AddForce (force);  // 力を加える
        }
    }

    // 衝突したときに呼ばれる
    void OnCollisionEnter(Collision collision)
    {
        SeVolume = savedatascript.SEvolume;
        // プレイヤーに当たったときに、跳ね返る方向を変える
        if (collision.gameObject.CompareTag("Player"))
        {
            // プレイヤーの位置を取得
            Vector3 playerPos = collision.transform.position;
            // ボールの位置を取得
            Vector3 ballPos = myTransform.position;
            // プレイヤーから見たボールの方向を計算
            Vector3 direction = (ballPos - playerPos).normalized;
            Vector3 direction2 = new Vector3(0f, 1f, 0f);
            direction = (direction + direction2);
            direction = direction.normalized;
            // 現在の速さを取得
            float speed = myRigidbody.velocity.magnitude;
            // 速度を変更
            myRigidbody.velocity = direction * speed;
            audioSource.PlayOneShot(sePlayer, SeVolume);
        }
        else if(collision.gameObject.CompareTag("Acceleration"))
        {
            i_speed = 1;
            rest_velocity = null;
            rest_velocity = speed_to_default();
            StartCoroutine(rest_velocity);
            Vector3 velocity = myRigidbody.velocity;
            speed = velocity_function(i_speed, speed);
            myRigidbody.velocity = speed * myRigidbody.velocity.normalized;
            audioSource.PlayOneShot(seDebuff, SeVolume);
        }
        else if(collision.gameObject.CompareTag("Deceleration"))
        {
            i_speed = 2;
            rest_velocity = null;
            rest_velocity = speed_to_default();
            StartCoroutine(rest_velocity);
            speed = velocity_function(i_speed, speed);
            myRigidbody.velocity = speed * myRigidbody.velocity.normalized;
            audioSource.PlayOneShot(seBuff, SeVolume);
        }
        else if(collision.gameObject.CompareTag("Expander"))
        {
            Public_Player.transform.localScale = new Vector3(1.4f, 0.1f, 1);
            rest_size = null;
            rest_size = size_to_default();
            StartCoroutine(rest_size);
            audioSource.PlayOneShot(seBuff, SeVolume);
        }
        else if(collision.gameObject.CompareTag("Shrinker"))
        {
            Public_Player.transform.localScale = new Vector3(0.7f, 0.1f, 1);
            rest_size = null;
            rest_size = size_to_default();
            StartCoroutine(rest_size);
            audioSource.PlayOneShot(seDebuff, SeVolume);
        }
        else if(collision.gameObject.CompareTag("Block") ^ collision.gameObject.CompareTag("OnOffBlock"))
        {
            audioSource.PlayOneShot(seBlockC5, SeVolume);
            // if (i_ballcollision % 8 == 0)
            // {
            //     AudioSource.PlayOneShot(seBlockC5, transform.position);
            // }
            // else if (i_ballcollision % 8 == 1)
            // {
            //     AudioSource.PlayOneShot(seBlockD, transform.position);
            // }
            // else if (i_ballcollision % 8 == 2)
            // {
            //     AudioSource.PlayOneShot(seBlockE, transform.position);
            // }
            // else if (i_ballcollision % 8 == 3)
            // {
            //     AudioSource.PlayOneShot(seBlockF, transform.position);
            // }
            // else if (i_ballcollision % 8 == 4)
            // {
            //     AudioSource.PlayOneShot(seBlockG, transform.position);
            // }
            // else if (i_ballcollision % 8 == 5)
            // {
            //     AudioSource.PlayOneShot(seBlockA, transform.position);
            // }
            // else if (i_ballcollision % 8 == 6)
            // {
            //     AudioSource.PlayOneShot(seBlockB, transform.position);
            // }
            // else if (i_ballcollision % 8 == 7)
            // {
            //     AudioSource.PlayOneShot(seBlockC6, transform.position);
            // }
            // i_ballcollision += 1;
        }

        // float tan_velocity = myRigidbody.velocity.y/myRigidbody.velocity.x;
        // if (Mathf.Abs(tan_velocity) < 0.05f)
        // {

        //     Vector3 force = new Vector3 (0.0f, Math.Sign(myRigidbody.velocity.y) * 3.0f,0.0f);    // 力を設定
        //     if (Math.Sign(myRigidbody.velocity.y) == 0f)
        //     {
        //         force = new Vector3 (0.0f, -Math.Sign(myRigidbody.position.y) * 5.0f, 0.0f);
        //     }
        //     myRigidbody.AddForce (force);  // 力を加える
        // }
        // else if (Mathf.Abs(tan_velocity) > 20.0f)
        // {
        //     Vector3 force = new Vector3 (Mathf.Max(Math.Sign(myRigidbody.velocity.x)) * 3.0f, 0.0f, 0.0f);    // 力を設定
        //     if (Math.Sign(myRigidbody.velocity.x) == 0f)
        //     {
        //         force = new Vector3 (-Math.Sign(myRigidbody.position.x) * 5.0f, 0.0f, 0.0f);
        //     }
        //     myRigidbody.AddForce (force);  // 力を加える
        // }
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

    IEnumerator speed_to_default()
    {
        // 10秒間待つ
        yield return new WaitForSeconds(10);

        // 10秒後に速度を戻す
        i_speed = 0;
    }

    IEnumerator size_to_default()
    {
        yield return new WaitForSeconds(10);
        Public_Player.transform.localScale = new Vector3(1.0f, 0.1f, 1);
    }


}