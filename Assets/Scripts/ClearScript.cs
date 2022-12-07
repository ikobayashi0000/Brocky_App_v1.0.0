using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearScript : MonoBehaviour
{
    int NormalBlock;
    int AccelerationBlock;
    int DecelerationBlock;
    int ExpanderBlock;
    int ShrinkerBlock;
    int HardBlock;
    int HeartBlock;
    int TripleBlock;
    [SerializeField] GameObject GameClear;
    int stage;

    GameObject savedata;
    ObtainCurrentStageNumber ObtainCurrentStageNumber;
    int nextstage;
    int completedstage;



    void Update()
    {
        NormalBlock = GameObject.FindGameObjectsWithTag("Block").Length;
        AccelerationBlock = GameObject.FindGameObjectsWithTag("Acceleration").Length;
        DecelerationBlock = GameObject.FindGameObjectsWithTag("Deceleration").Length;
        ExpanderBlock = GameObject.FindGameObjectsWithTag("Expander").Length;
        ShrinkerBlock = GameObject.FindGameObjectsWithTag("Shrinker").Length;
        HardBlock = GameObject.FindGameObjectsWithTag("HardBlock").Length;
        HeartBlock = GameObject.FindGameObjectsWithTag("Heart").Length;
        TripleBlock = GameObject.FindGameObjectsWithTag("Triple").Length;
        int count = NormalBlock + AccelerationBlock + DecelerationBlock + ExpanderBlock + ShrinkerBlock + HardBlock + HeartBlock + TripleBlock;
        if(count == 0)
        {
            GameClear.SetActive(true);
            Time.timeScale = 0.0f;
            savedata = GameObject.Find("SaveData");
            ObtainCurrentStageNumber = savedata.GetComponent<ObtainCurrentStageNumber>();
            nextstage = ObtainCurrentStageNumber.CurrentStage + 1;
            completedstage = PlayerPrefs.GetInt("clearstage", 1);
            nextstage = System.Math.Max(nextstage, completedstage);
            if(nextstage > 35)
            {
                nextstage = 35;
            }
            PlayerPrefs.SetInt ("clearstage", nextstage);
        }
    }
}