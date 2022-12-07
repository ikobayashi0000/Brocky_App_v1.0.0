using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObtainCurrentStageNumber : MonoBehaviour
{
    public int CurrentStage;
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Stage1_1Scene")
        {
            CurrentStage = 1;
        }
        else if(SceneManager.GetActiveScene().name == "Stage1_2Scene")
        {
            CurrentStage = 2;
        }
        else if(SceneManager.GetActiveScene().name == "Stage1_3Scene")
        {
            CurrentStage = 3;
        }
        else if(SceneManager.GetActiveScene().name == "Stage1_4Scene")
        {
            CurrentStage = 4;
        }
        else if(SceneManager.GetActiveScene().name == "Stage1_5Scene")
        {
            CurrentStage = 5;
        }
        else if(SceneManager.GetActiveScene().name == "Stage2_1Scene")
        {
            CurrentStage = 6;
        }
        else if(SceneManager.GetActiveScene().name == "Stage2_2Scene")
        {
            CurrentStage = 7;
        }
        else if(SceneManager.GetActiveScene().name == "Stage2_3Scene")
        {
            CurrentStage = 8;
        }
        else if(SceneManager.GetActiveScene().name == "Stage2_4Scene")
        {
            CurrentStage = 9;
        }
        else if(SceneManager.GetActiveScene().name == "Stage2_5Scene")
        {
            CurrentStage = 10;
        }
        else if(SceneManager.GetActiveScene().name == "Stage3_1Scene")
        {
            CurrentStage = 11;
        }
        else if(SceneManager.GetActiveScene().name == "Stage3_2Scene")
        {
            CurrentStage = 12;
        }
        else if(SceneManager.GetActiveScene().name == "Stage3_3Scene")
        {
            CurrentStage = 13;
        }
        else if(SceneManager.GetActiveScene().name == "Stage3_4Scene")
        {
            CurrentStage = 14;
        }
        else if(SceneManager.GetActiveScene().name == "Stage3_5Scene")
        {
            CurrentStage = 15;
        }
        else if(SceneManager.GetActiveScene().name == "Stage4_1Scene")
        {
            CurrentStage = 16;
        }
        else if(SceneManager.GetActiveScene().name == "Stage4_2Scene")
        {
            CurrentStage = 17;
        }
        else if(SceneManager.GetActiveScene().name == "Stage4_3Scene")
        {
            CurrentStage = 18;
        }
        else if(SceneManager.GetActiveScene().name == "Stage4_4Scene")
        {
            CurrentStage = 19;
        }
        else if(SceneManager.GetActiveScene().name == "Stage4_5Scene")
        {
            CurrentStage = 20;
        }
        else if(SceneManager.GetActiveScene().name == "Stage5_1Scene")
        {
            CurrentStage = 21;
        }
        else if(SceneManager.GetActiveScene().name == "Stage5_2Scene")
        {
            CurrentStage = 22;
        }
        else if(SceneManager.GetActiveScene().name == "Stage5_3Scene")
        {
            CurrentStage = 23;
        }
        else if(SceneManager.GetActiveScene().name == "Stage5_4Scene")
        {
            CurrentStage = 24;
        }
        else if(SceneManager.GetActiveScene().name == "Stage5_5Scene")
        {
            CurrentStage = 25;
        }
        else if(SceneManager.GetActiveScene().name == "Stage6_1Scene")
        {
            CurrentStage = 26;
        }
        else if(SceneManager.GetActiveScene().name == "Stage6_2Scene")
        {
            CurrentStage = 27;
        }
        else if(SceneManager.GetActiveScene().name == "Stage6_3Scene")
        {
            CurrentStage = 28;
        }
        else if(SceneManager.GetActiveScene().name == "Stage6_4Scene")
        {
            CurrentStage = 29;
        }
        else if(SceneManager.GetActiveScene().name == "Stage6_5Scene")
        {
            CurrentStage = 30;
        }
        else if(SceneManager.GetActiveScene().name == "Stage7_1Scene")
        {
            CurrentStage = 31;
        }
        else if(SceneManager.GetActiveScene().name == "Stage7_2Scene")
        {
            CurrentStage = 32;
        }
        else if(SceneManager.GetActiveScene().name == "Stage7_3Scene")
        {
            CurrentStage = 33;
        }
        else if(SceneManager.GetActiveScene().name == "Stage7_4Scene")
        {
            CurrentStage = 34;
        }
        else if(SceneManager.GetActiveScene().name == "Stage7_5Scene")
        {
            CurrentStage = 35;
        }


    }
}
