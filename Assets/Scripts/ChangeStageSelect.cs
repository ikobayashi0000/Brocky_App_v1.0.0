using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStageSelect : MonoBehaviour
{
    [SerializeField] GameObject StageSelect1;
    [SerializeField] GameObject StageSelect2;

    // Update is called once per frame
    public void OnClick()
    {
        StageSelect1.SetActive(!StageSelect1.gameObject.activeSelf);
        StageSelect2.SetActive(!StageSelect2.gameObject.activeSelf);
    }
}