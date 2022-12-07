using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateMagmaScript : MonoBehaviour
{
    public float timeElapsed;
    public float interval = 5.0f;
    GameObject db;

    void Start()
    {
        db = (GameObject)Resources.Load("MagmaPrefab");
        int stage = SceneManager.GetActiveScene().buildIndex;
        if(stage > 17)
        {
            interval -= 1.0f;
        }
    }


    void Update()
    {
        timeElapsed += Time.deltaTime;

        if(timeElapsed >= interval)
        {
            float size = db.transform.localScale.x;
            Vector3 position = new Vector3(Random.Range(-2.25f+size, 2.25f-size), Random.Range(0.0f, 3.5f-size), 0);
            Instantiate(db, position, Quaternion.identity);
            timeElapsed = 0.0f;
        }
        
    }
}
