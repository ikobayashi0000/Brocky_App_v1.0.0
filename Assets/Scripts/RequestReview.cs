using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestReview : MonoBehaviour
{

    [SerializeField] GameObject GameClear;
    bool request = false;

    // Update is called once per frame
    void Update()
    {
        if (GameClear.gameObject.activeSelf == true & request == false)
        {
            UnityEngine.iOS.Device.RequestStoreReview();
            request = true;
        }
    }
}