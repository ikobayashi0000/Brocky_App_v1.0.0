using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody myRigidbody;
    Transform myTransform;
    public static Touch[] touches {get;}
    Camera mainCamera;
    float PlayerPosY;
    float PlayerPosZ;
    float MIN = -2.313f;
    float MAX = 2.313f;
    Vector3 posActive;
    Vector3 posStop;
    [SerializeField] GameObject Stop;
    [SerializeField] GameObject GameOver;
    [SerializeField] GameObject Settings;
    [SerializeField] GameObject Clear;
    [SerializeField] GameObject Continue;
    //[SerializeField] GameObject GameClear;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myTransform = this.transform;
        mainCamera = Camera.main;
        PlayerPosY = -3.0667f;
        PlayerPosZ = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float scale = myTransform.localScale.x / 2.0f;
        float min = MIN + scale;
        float max = MAX - scale;
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = PlayerPosZ;
        mousePos.y = PlayerPosY;
        mousePos.x = Mathf.Clamp(mousePos.x, min, max);

        posActive = mousePos;

        if(Stop.activeSelf | GameOver.activeSelf | Settings.activeSelf | Clear.activeSelf | Continue.activeSelf)
        {
            myTransform.position = posStop;
        }
        else
        {
            myTransform.position = posActive;
            posStop = posActive;
        }
    }
}