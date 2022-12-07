using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomColorScript : MonoBehaviour
{
    //色は増やせる
    // UnityEngine.Color[] colorArray = new Color[] { new Color(255/255f, 87/255f, 127/255f), 
    //                    new Color(255/255f, 136/255f, 75/255f),
    //                    new Color(255/255f, 199/255f, 100/255f),
    //                    new Color(205/255f, 255/255f, 252/255f)};
    

    // void Start()
    // {
    //     //乱数の準備
    //     //InitStateの中身がseed
    //     UnityEngine.Random.InitState(2);
    //     GameObject[] Blocks = GameObject.FindGameObjectsWithTag("Block");
    //     float[] floatValue = new float[Blocks.Length];
    //     for (int i = 0; i < Blocks.Length; i++)
    //     {
    //         float random = Random.value;
    //         int colorlength = colorArray.Length;
    //         for (int j = 0; j < colorArray.Length; j++)
    //         {
    //             if( ((float)j + 1.0f)/((float)colorlength) > random & random > (float)j/((float)colorlength) )
    //             {
    //                 Blocks[i].GetComponent<Renderer>().material.color = colorArray[j];
    //             }
    //         }
    //     }
    // }
}