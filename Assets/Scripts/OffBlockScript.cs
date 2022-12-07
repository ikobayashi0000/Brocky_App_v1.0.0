using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EventBridge;

public class OffBlockScript : MonoBehaviour
{
    public GameObject OffBlock;
    public GameObject EmptyBlock;
    private IComponentEventHandler _eventHandler;
    void Start()
    {
        OffBlock.gameObject.SetActive(false);
        EmptyBlock.gameObject.SetActive(true);
        _eventHandler = OffBlock.RequestEventHandlers();
        _eventHandler.CollisionEnter += OnObjectTouchedBlock;
    }
    private void OnObjectTouchedBlock(Collision collision)
    {
        Destroy(gameObject);
    }
}