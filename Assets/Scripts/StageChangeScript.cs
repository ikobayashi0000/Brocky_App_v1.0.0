using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageChangeScript : MonoBehaviour
{
    [SerializeField] GameObject Stages1;
    [SerializeField] GameObject Stages2;

        public void OnClick()
    {
        if(Stages1.activeSelf)
        {
            Stages1.SetActive(false);
            Stages2.SetActive(true);
        }
        else
        {
            Stages1.SetActive(true);
            Stages2.SetActive(false);
        }
        
    }
}
