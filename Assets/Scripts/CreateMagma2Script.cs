using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateMagma2Script : MonoBehaviour
{
    public float timeElapsed2;
    public float interval = 6.0f;

    void Start()
    {
        int stage = SceneManager.GetActiveScene().buildIndex;
        if(stage > 17)
        {
            interval -= 1.0f;
        }
    }


    void Update()
    {
        timeElapsed2 += Time.deltaTime;
        if(timeElapsed2 >= interval)
        {
            GameObject db = (GameObject)Resources.Load("MagmaPrefab2");
            float size = db.transform.localScale.x;
            Vector3 position = new Vector3(Random.Range(-2.25f+size, 2.25f-size), -4.6f+size, 0);
            Instantiate(db, position, Quaternion.identity);
            timeElapsed2 = 0.0f;
        }
        
    }
}
