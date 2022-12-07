using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectActiveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] Selects = new Button[35];
    private int stage;

    // Update is called once per frame
    void Start()
    {
        stage = PlayerPrefs.GetInt("clearstage", 1);
        for(int i_stage = 0; i_stage <= 34; i_stage++)
        {
            if (i_stage <= stage - 1)
            {
                Selects[i_stage].enabled = true;
            }
            else
            {
                Selects[i_stage].interactable = false;
            }
        }
    }
}