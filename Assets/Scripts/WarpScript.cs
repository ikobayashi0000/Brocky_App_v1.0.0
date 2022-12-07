using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Warmhole;
    public static bool warpbool = true;
    GameObject Ball;
    WarpCountScript WarpCount;
    // Update is called once per frame
    // <summary>
	/// トリガーの範囲に入っている間ずっと実行される
	// </summary>
	// <param name="other"></param>

	private void OnTriggerStay(Collider other)
    {
        if(warpbool == true)
        {
            other.gameObject.transform.position = Warmhole.position;
            float force_x = Random.Range(-10.0f, 10.0f);
            float force_y = Random.Range(-10.0f, 10.0f);
            Vector3 force = new Vector3(force_x, force_y, 0.0f);
            other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
            other.gameObject.GetComponent<Rigidbody>().AddForce(force);
            warpbool = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Ball = other.gameObject;
        WarpCount = Ball.GetComponent<WarpCountScript>();
        WarpCount.count += 1;
        int check = WarpCount.count;
        if(check == 2)
        {
            warpbool = true;
            WarpCount.count = 0;
        }

    }
    
}