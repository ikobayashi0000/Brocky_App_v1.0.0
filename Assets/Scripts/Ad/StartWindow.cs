using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EventBridge;


// リワード広告表示スクリプト
public class StartWindow : MonoBehaviour
{
    private RewardedAd rewardedAd = null;
    // テスト用広告ユニットID
    private string adId = "ca-app-pub-3940256099942544/5224354917";
    private bool rewardedAdRetry = false;
    GameObject cubebottom;
    CubebottomScript cubebottomScript;
    public GameObject LifeRecoverMenu;
    [SerializeField] private Transform _objectToObserve;
    private IComponentEventHandler _eventHandler;
    public bool SetBall = true;

    // Start is called before the first frame update
    
    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
        LoadRewardAd();
    }

    // Update is called once per frame
    void Update()
    {
        if (rewardedAdRetry) {
            LoadRewardAd();
            rewardedAdRetry = false;
        }
    }

    public void OnClick()
    {
        ShowRewardAd();
    }

    public bool ShowRewardAd()
    {
        if (rewardedAd.IsLoaded()) {
            rewardedAd.Show();
            return true;
        } else {
            Debug.Log("not loaded");
            return false;
        }
    }

    void LoadRewardAd()
    {
        // Clean up banner ad before creating a new one.
        if (rewardedAd != null) {
            rewardedAd = null;
        }

        rewardedAd = new RewardedAd(adId);
        // Register for ad events.
        rewardedAd.OnAdLoaded += HandleRewardAdLoaded;
        rewardedAd.OnAdFailedToLoad += HandleRewardAdFailedToLoad;
        rewardedAd.OnAdOpening += HandleRewardedAdAdOpened;
        rewardedAd.OnAdClosed += HandleRewardedAdAdClosed;
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;

        AdRequest adRequest = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(adRequest);
    }
    public void HandleRewardAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("HandleRewardAdLoaded event received with message: " + args);
        rewardedAdRetry = false;
    }

    ///読み込みに失敗したとしてもリワードを与える
    public void HandleRewardAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        LoadAdError loadAdError = args.LoadAdError;
        int code = loadAdError.GetCode();
        string message = loadAdError.GetMessage();


        Debug.Log("Load error string: " + loadAdError.ToString());
        Debug.Log("code: " + code.ToString());

        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: "
                             + message);
        if (code == 2 || code == 0) {
            Debug.Log("error");
        } else {
            Debug.Log("error no fill");
        }
        rewardedAdRetry = true;
        cubebottom = GameObject.Find("Cubebottom");
        cubebottomScript = cubebottom.GetComponent<CubebottomScript>();
        cubebottomScript.heartcount = 1;
        LifeRecoverMenu.SetActive(false);
        Time.timeScale = 1f;
        cubebottomScript.CreatenewBall();
        OnDestroy();
    }
    public void HandleRewardedAdAdOpened(object sender, EventArgs args)
    {
        Debug.Log("HandleRewardedAdAdOpened event received");
    }
    
    ///showに失敗したとしてもリワードを与える
    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.AdError.GetMessage());
        cubebottom = GameObject.Find("Cubebottom");
        cubebottomScript = cubebottom.GetComponent<CubebottomScript>();
        cubebottomScript.heartcount = 1;
        LifeRecoverMenu.SetActive(false);
        Time.timeScale = 1f;
        cubebottomScript.CreatenewBall();
        OnDestroy();
    }
    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);
    }
    public void HandleRewardedAdAdClosed(object sender, EventArgs args)
    {
        Debug.Log("HandleRewardedAdClosed event received");
        rewardedAdRetry = true;
        OnDestroy();

        cubebottom = GameObject.Find("Cubebottom");
        cubebottomScript = cubebottom.GetComponent<CubebottomScript>();
        cubebottomScript.heartcount = 1;
        LifeRecoverMenu.SetActive(false);
        Time.timeScale = 1f;
        cubebottomScript.CreatenewBall();
    }

    private void OnDestroy()
    {
        // オブジェクトの破棄
        rewardedAd.Destroy();
    }
    
}