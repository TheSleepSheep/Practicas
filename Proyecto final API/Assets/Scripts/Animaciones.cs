using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    public GameObject logo;
    public GameObject canvas;
    public GameObject inicio;
    public GameObject imagen;
    public GameObject skin;
    public GameObject skintwo;
    public GameObject skinext;
    public GameObject not;
    public GameObject miel;
    public GameObject amor;
    public bool menuON;


    void Start()
    {
        LeanTween.moveX(rectTrans:logo.GetComponent<RectTransform>(), to:13f, time:1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutBounce).setOnComplete(BajarAlpha);
    }

    public void BajarAlpha()
    {
        LeanTween.alpha(canvas.GetComponent<RectTransform>(), to:0, time:1f).setDelay(1f).setOnComplete(Bajar);
    }

    public void Bajar()
    {
        LeanTween.moveY(rectTrans: inicio.GetComponent<RectTransform>(), to: -920f, time: 0.1f).setDelay(0.5f);
    }

    public void Deslizar()
    {
        if(!menuON)
        {
            LeanTween.moveX(imagen.GetComponent<RectTransform>(), to: -970, time: 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
            menuON = true;
        }
        else
        {
            LeanTween.moveX(imagen.GetComponent<RectTransform>(), to: -1710, time: 1f).setDelay(0.5f).setEase(LeanTweenType.easeInElastic);
            menuON = false;
        }
     
    }
    public void Tienda()
    {
        LeanTween.moveX(skin.GetComponent<RectTransform>(), to: -1660, time: 0.1f).setDelay(0.5f);
        LeanTween.moveX(skintwo.GetComponent<RectTransform>(), to: -294, time: 0.1f).setDelay(0.5f);
        LeanTween.moveX(skinext.GetComponent<RectTransform>(), to: 595, time: 0.1f).setDelay(0.5f);
    }

    public void Tiendaback()
    {
        LeanTween.moveX(skin.GetComponent<RectTransform>(), to: -594, time: 0.1f).setDelay(0.5f);
        LeanTween.moveX(skintwo.GetComponent<RectTransform>(), to: 304, time: 0.1f).setDelay(0.5f);
        LeanTween.moveX(skinext.GetComponent<RectTransform>(), to: 1620, time: 0.1f).setDelay(0.5f);
    }
    public void Noticias()
    {
        LeanTween.moveX(rectTrans: not.GetComponent<RectTransform>(), to: -920f, time: 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutBounce).setOnComplete(BajarAlpha);
        LeanTween.moveY(rectTrans: miel.GetComponent<RectTransform>(), to: 350, time: 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(BajarAlpha);
        LeanTween.moveX(rectTrans: amor.GetComponent<RectTransform>(), to: 510, time: 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutCirc).setOnComplete(BajarAlpha);
    }

    public void NoticiasBack()
    {
        LeanTween.moveX(rectTrans: not.GetComponent<RectTransform>(), to: -1740f, time: 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeInBounce).setOnComplete(BajarAlpha);
        LeanTween.moveY(rectTrans: miel.GetComponent<RectTransform>(), to: 1100, time: 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeInElastic).setOnComplete(BajarAlpha);
        LeanTween.moveX(rectTrans: amor.GetComponent<RectTransform>(), to: 2070, time: 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeInCirc).setOnComplete(BajarAlpha);
    }
  

}




