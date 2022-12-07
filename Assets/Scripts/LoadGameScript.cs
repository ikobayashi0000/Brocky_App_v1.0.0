using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        int stagenumber = PlayerPrefs.GetInt("clearstage", 1);
        SceneManager.LoadScene(stagenumber);
        Time.timeScale = 1.0f;
    }
}
