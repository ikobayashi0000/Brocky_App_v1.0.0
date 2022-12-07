using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    [SerializeField] GameObject StopMenu;
    [SerializeField] GameObject Canvas1;

    public void OnClick()
    {
        StopMenu.SetActive(false);
        Canvas1.SetActive(true);
        Time.timeScale = 1f;
    }
}
