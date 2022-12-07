using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using System;
using UniRx;

// Homeに戻る際に広告を表示するためのスクリプト
public class AdmobHome : MonoBehaviour
{
    /** 変数 */
    private InterstitialAd interstitial;
    public string loadEventParam; // 読込イベント名(遷移元で渡されるゴロ)

    void Start()
    {
        // 広告読み込み
        RequestInterstitial();
    }

    public void OnClick()
    {
        // 広告表示
        interstitial.Show();
    }

    // 広告読み込み処理
    private void RequestInterstitial()
    {
        // ★リリース時に自分のIDに変更する
        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-3940256099942544/1033173712";
        #elif UNITY_IPHONE
                string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
                string adUnitId = "unexpected_platform";
        #endif


        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.interstitial.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is shown.
        this.interstitial.OnAdOpening += HandleOnAdOpened;
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }

    // シーン遷移処理
    private void LoadNextScene()
    {
        SceneManager.LoadScene("Scenes/HomeScene");
        Time.timeScale = 1f;
    }

    private void OnDestroy()
    {
        // オブジェクトの破棄
        interstitial.Destroy();
    }

    // ---以下、イベントハンドラー
    
    // 広告の読み込み完了時
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
    }

    // 広告の読み込み失敗時
    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        // 次のシーンに遷移
        interstitial.Destroy();
        LoadNextScene();
    }

    // 広告がデバイスの画面いっぱいに表示されたとき
    public void HandleOnAdOpened(object sender, EventArgs args)
    {
    }

    // 広告を閉じたとき
    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        interstitial.Destroy();
        LoadNextScene();
    }
    
}