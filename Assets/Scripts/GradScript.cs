using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradScript : MonoBehaviour
{
    // Start is called before the first frame update
    float timeElapsed;
    bool frag;
    public GameObject clearfinal;
    void Start()
    {
        Time.timeScale = 1.0f;
        StartCoroutine("Coroutine");
    }
    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(12.0f);
        clearfinal.SetActive(true);
        yield break;
    }
}