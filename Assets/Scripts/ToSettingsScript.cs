using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSettingsScript : MonoBehaviour
{
    [SerializeField] GameObject Settings;

    public void OnClick()
    {
        Settings.SetActive(!Settings.gameObject.activeSelf);
    }
}