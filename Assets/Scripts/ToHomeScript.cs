using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToHomeScript : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Scenes/HomeScene");
        Time.timeScale = 1f;
    }
}
