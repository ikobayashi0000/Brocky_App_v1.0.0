using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SlideShow : MonoBehaviour
{
    [SerializeField] Sprite[] images;

    [Space(5f)]

    [SerializeField] Image nextImage;
    [SerializeField] Image prevImage;

    [Space(5f)]

    public int waitTime = 5;
    public float changeSlideTime = 0.5f;

    Color visible = new Color(1f, 1f, 1f, 1f);
    Color invisible = new Color(1f, 1f, 1f, 0f);

    void Start()
    {
        StartCoroutine(slide());
    }

    public IEnumerator slide()
    {
        int count = 0;
        int length = images.Length;

        bool fadein = false;
        bool fadeout = false;

        var prevImageObject = prevImage.gameObject;
        var nextImageObject = nextImage.gameObject;

        while(count < length)
        {
            //画像をセット
            prevImage.sprite = images[count];
            nextImage.sprite = images[(count+1) % length];

            yield return new WaitForSeconds(waitTime);

            //fadeout
            DOTween.ToAlpha(
                () => prevImage.color,
                color => prevImage.color = color,
                0f,
                changeSlideTime
            ).OnComplete(() => fadeout = true);

            //fadein
            DOTween.ToAlpha(
                () => nextImage.color,
                color => nextImage.color = color,
                1f,
                changeSlideTime
            ).OnComplete(() => fadein = true);

            while(fadeout == false || fadein == false){ yield return null; }

            prevImageObject.SetActive(false);
            prevImage.sprite = nextImage.sprite;
            prevImage.color = visible;
            prevImageObject.SetActive(true);

            nextImageObject.SetActive(false);
            nextImage.color = invisible;
            nextImageObject.SetActive(true);

            count++;
            fadein = false;
            fadeout = false;

            //スライドが最後までいったらリセットする
            if(count == images.Length)
            {
                count = 0;
            }
        }
    }
}
