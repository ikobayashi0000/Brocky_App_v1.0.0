using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmManager : MonoBehaviour
{
    [SerializeField] public Slider slider;
    AudioSource audioSource;
    GameObject savedata;
    SaveDataScript savedatascript;
    [SerializeField] public GameObject Sound_Home;
    float temp_bgmvolume;
    GameObject BGM_via;
    BGM_viaScript bgmviascript;
    bool musicstop;

    void Start()
    {
        Sound_Home = GameObject.Find("Sound_Home");
        savedata = GameObject.Find("SaveData");
        savedatascript = savedata.GetComponent<SaveDataScript>();

        BGM_via = GameObject.Find("BGM_via");
        bgmviascript = BGM_via.GetComponent<BGM_viaScript>();
        slider = bgmviascript.slider;

        slider.maxValue = 0.2f;
        slider.minValue = 0.0f;
        slider.value = PlayerPrefs.GetFloat("BGM", 0.03f);
        audioSource = GetComponent<AudioSource>();
        musicstop = false;
    }

    void Update()
    {
        savedatascript = savedata.GetComponent<SaveDataScript>();
        savedatascript.BGMvolume = slider.value;
        audioSource.volume = savedatascript.BGMvolume;
        temp_bgmvolume = audioSource.volume;
        if (Time.timeScale == 0.0f & musicstop == false)
        {
            audioSource.Pause();
            musicstop = true;
        }
        if (Time.timeScale == 1.0f & musicstop == true)
        {
            audioSource.UnPause();
            musicstop = false;
        }
    }

    void OnDestroy()
    {
        PlayerPrefs.SetFloat ("BGM", temp_bgmvolume);
    }
}