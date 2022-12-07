using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveDataScript : MonoBehaviour
{
	//　publicデータ
	public int stage;
	public float SEvolume;
    public float BGMvolume;

    void Start()
    {
        Application.targetFrameRate = 100;
    }
 
    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt ("clearstage", stage);
        PlayerPrefs.SetFloat ("SE", SEvolume);
        PlayerPrefs.SetFloat ("BGM", BGMvolume);
    }

    void Awake()
    {
        stage = PlayerPrefs.GetInt("clearstage", 35);
        SEvolume = PlayerPrefs.GetFloat("SE", 0.1f);
        BGMvolume = PlayerPrefs.GetFloat("BGM", 0.03f);
    }
}