using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    public GameObject logo;
    public GameObject canvas;


    void Start()
    {
        LeanTween.moveX(rectTrans:logo.GetComponent<RectTransform>(), to:13f, time:1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutBounce).setOnComplete(BajarAlpha);
    }

    public void BajarAlpha()
    {
        LeanTween.alpha(canvas.GetComponent<RectTransform>(), to:0, time:2f).setDelay(1f);
    }
        

}
