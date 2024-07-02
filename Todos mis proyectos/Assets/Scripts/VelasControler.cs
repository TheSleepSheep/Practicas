using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using System.Net.NetworkInformation;

public class VelasControler : MonoBehaviour
{
    private TMP_Dropdown VelasOptions;
    public Image velas;

    public Sprite[] VelasBase;

    void Start()
    {

        VelasOptions = GetComponent<TMP_Dropdown>();
        velas = GameObject.Find("Velas").GetComponent<Image>();

    }
    public void ChangeVelas()
    {
        switch (VelasOptions.value)
        {
            case 0:
                velas.sprite = VelasBase[0];
                break;
            case 1:
                velas.sprite = VelasBase[1];
                break;
            case 2:
                velas.sprite = VelasBase[2];
                break;
        }
    }
}
