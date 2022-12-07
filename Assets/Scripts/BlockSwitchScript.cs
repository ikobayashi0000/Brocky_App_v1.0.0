using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSwitchScript : MonoBehaviour
{
    GameObject[] OnOffBlocks;
    void Awake()
    {
        OnOffBlocks = GameObject.FindGameObjectsWithTag("OnOffBlock");
    }
    // Update is called once per frame
    void OnCollisionEnter()
    {
        List<GameObject> list = new List<GameObject>(OnOffBlocks);
        list.RemoveAll(item => item == null);
        OnOffBlocks = list.ToArray();

        foreach(GameObject OnOffBlock in OnOffBlocks)
        {
            bool OnOff = OnOffBlock.gameObject.activeSelf;
            OnOff = !OnOff;
            OnOffBlock.gameObject.SetActive(OnOff);
        }
    }
}