using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using System.Net.NetworkInformation;

public class AdornoControles : MonoBehaviour
{
    private TMP_Dropdown AdornoOptions;
    public Image adornos;

    public Sprite[] AdornosBase;

    void Start()
    {
        AdornoOptions = GetComponent<TMP_Dropdown>();
        adornos = GameObject.Find("Adorno").GetComponent<Image>();
    }

    public void ChangeAdorno()
    {
        switch (AdornoOptions.value)
        {
            case 0:
                adornos.sprite = AdornosBase[0];
                break;
            case 1:
                adornos.sprite = AdornosBase[1];
                break;
            case 2:
                adornos.sprite = AdornosBase[2];
                break;
        }
    }

}
