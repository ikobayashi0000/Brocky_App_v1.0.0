using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopScript : MonoBehaviour
{
    [SerializeField] GameObject StopMenu;
    [SerializeField] GameObject Canvas1;

    public void OnClick()
    {
        StopMenu.SetActive(true);
        Canvas1.SetActive(false);
        Time.timeScale = 0f;
    }
}
