using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeManager : MonoBehaviour
{
    [SerializeField] public Slider SeSlider;
    GameObject savedata;
    SaveDataScript savedatascript;
    private GameObject SliderObject;
    [SerializeField] public GameObject Sound_Home;
    float temp_sevolume;

    void Start()
    {
        savedata = GameObject.Find("SaveData");
        SeSlider.minValue = 0.0f;
        SeSlider.maxValue = 0.3f;
        SeSlider.value = PlayerPrefs.GetFloat("SE", 0.1f);
    }

    void Update()
    {
        savedatascript = savedata.GetComponent<SaveDataScript>();
        savedatascript.SEvolume = SeSlider.value;
        temp_sevolume = SeSlider.value;
    }
    void OnDestroy()
    {
        PlayerPrefs.SetFloat ("SE", temp_sevolume);
    }
}