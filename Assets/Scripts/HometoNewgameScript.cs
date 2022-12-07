using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HometoNewgameScript : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Scenes/Stages1Folder/Stage1_1Scene");
    }
}
