using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardScript : MonoBehaviour
{
    //色は要検討
    public SpriteRenderer spriterenderer;
    public Sprite sprite;
    private int CountCollision;
    public AudioClip seHardBlock1;
    public AudioClip seHardBlock2;
    GameObject savedata;
    SaveDataScript savedatascript;
    AudioSource audioSource;
    float SeVolume;
    GameObject HardBlockSE;

    void Start()
    {
        savedata = GameObject.Find("SaveData");
        savedatascript = savedata.GetComponent<SaveDataScript>();
        HardBlockSE = GameObject.Find("HardBlockSE");
        audioSource = HardBlockSE.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        SeVolume = savedatascript.SEvolume;
        if (CountCollision == 0)
        {
            spriterenderer.sprite = sprite;
            CountCollision = 1;
            audioSource.PlayOneShot(seHardBlock1, SeVolume);
        }
        else if (CountCollision == 1)
        {
            audioSource.PlayOneShot(seHardBlock2, SeVolume);
            Destroy(gameObject);
        }
    }
}