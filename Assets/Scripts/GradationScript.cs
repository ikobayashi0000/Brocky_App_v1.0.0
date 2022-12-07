using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class GradationScript : MonoBehaviour
{
 
    void Update()
    {
        // 現在使用されているマテリアルを取得
        Material mat = this.GetComponent<Renderer>().material;
        // マテリアルの色設定に赤色を設定
        mat.color = Color.Lerp(Color.red, Color.blue, Mathf.PingPong(Time.time, 1));
    }
}