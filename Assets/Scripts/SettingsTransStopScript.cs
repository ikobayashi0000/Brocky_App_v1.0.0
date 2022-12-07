using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsTransStopScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject StopMenu;

    public void OnClick()
    {
        StopMenu.SetActive(!StopMenu.gameObject.activeSelf);
    }
}