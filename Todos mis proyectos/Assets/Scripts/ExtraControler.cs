using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net.NetworkInformation;

public class ExtraControler : MonoBehaviour
{

    private TMP_Dropdown ExtraOptions;
    public Image extra;

    public Sprite[] ExtrasBase;

    void Start()
    {
        ExtraOptions = GetComponent<TMP_Dropdown>();
        extra = GameObject.Find("Chispitas").GetComponent<Image>();
    }

    public void ChangeExtras()
    {
        switch (ExtraOptions.value)
        {
            case 0:
                extra.sprite = ExtrasBase[0];
                break;
            case 1:
                extra.sprite = ExtrasBase[1];
                break;
            case 2:
                extra.sprite = ExtrasBase[2];
                break;
        }
    }

}
