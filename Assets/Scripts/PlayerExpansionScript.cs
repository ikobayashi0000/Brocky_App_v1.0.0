using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExpansionScript : MonoBehaviour
{
    public GameObject Public_Player;
    void OnCollisionEnter(Collision Collision)
    {
        float seconds = 7.0f;
        Public_Player.transform.localScale = new Vector3(1.5f, 0.06675578f, 1);
        StartCoroutine(StopTransform(seconds));
    }

    IEnumerator StopTransform(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Public_Player.transform.localScale = new Vector3(1.0f, 0.06675578f, 1);
    }
}