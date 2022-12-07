using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EventBridge;

public class CubebottomScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] heartArray = new GameObject[3];
    public GameObject[] Ball;
    public int heartcount;
    [SerializeField] private Transform _objectToObserve;
    private IComponentEventHandler _eventHandler;
    public bool SetBall = true;
    
    void Start()
    {
        heartcount = 2;
        _eventHandler = _objectToObserve.RequestEventHandlers();
        _eventHandler.CollisionEnter += OnObjectTouchedBlock;
        heartprint();
    }

    private void OnObjectTouchedBlock(Collision collision)
    {
        if(collision.gameObject.CompareTag("Heart") && heartcount < 3)
        {
            heartcount = heartcount + 1;
        }
        heartprint();
    }

    void FixedUpdate()
    {
        heartprint();
    }

    private void OnDestroy()
    {
        //You should always unsubscribe from the events when the object is destroyed
        _eventHandler.CollisionEnter -= OnObjectTouchedBlock;
    }

    // Update is called once per frame
    [SerializeField] GameObject GameOver;

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        int count = GameObject.FindGameObjectsWithTag("Ball").Length;
        if(count == 1)
        {
            heartcount = heartcount - 1;
            if(heartcount == 0)
            {
                GameOver.SetActive(true);
            }
            else if(heartcount > 0)
            {
                CreatenewBall();
                SetBall = true;
            }
        }
        heartprint();
    }



    public void CreatenewBall()
    {
        GameObject ball = (GameObject)Resources.Load("NewBallPrefab");
        GameObject ball_clone = Instantiate(ball);
        _objectToObserve = ball_clone.transform;
        _eventHandler = _objectToObserve.RequestEventHandlers();
        _eventHandler.CollisionEnter += OnObjectTouchedBlock;
    }
    void heartprint()
    {
        if(heartcount == 3)
        {
            heartArray[2].gameObject.SetActive(true);
            heartArray[1].gameObject.SetActive(true);
            heartArray[0].gameObject.SetActive(true);
        }
    
        if(heartcount == 2)
        {
            heartArray[2].gameObject.SetActive(false);
            heartArray[1].gameObject.SetActive(true);
            heartArray[0].gameObject.SetActive(true);
        }
        if(heartcount == 1)
        {
            heartArray[2].gameObject.SetActive(false);
            heartArray[1].gameObject.SetActive(false);
            heartArray[0].gameObject.SetActive(true);
        }
    
        if(heartcount == 0)
        {
            heartArray[2].gameObject.SetActive(false);
            heartArray[1].gameObject.SetActive(false);
            heartArray[0].gameObject.SetActive(false);
            GameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
