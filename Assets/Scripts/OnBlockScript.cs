using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EventBridge;

public class OnBlockScript : MonoBehaviour
{
    public GameObject OnBlock;
    public GameObject EmptyBlock;
    private IComponentEventHandler _eventHandler;
    void Start()
    {
        OnBlock.gameObject.SetActive(true);
        EmptyBlock.gameObject.SetActive(false);
        _eventHandler = OnBlock.RequestEventHandlers();
        _eventHandler.CollisionEnter += OnObjectTouchedBlock;
    }
    private void OnObjectTouchedBlock(Collision collision)
    {
        Destroy(gameObject);
    }
}