using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShrinkScript : MonoBehaviour
{
    public GameObject Public_Player;
    void OnCollisionEnter(Collision Collision)
    {
        Public_Player.transform.localScale = new Vector3(0.6f, 0.06675578f, 1);
    }

}