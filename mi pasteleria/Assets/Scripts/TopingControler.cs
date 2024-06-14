using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TopingControler : MonoBehaviour
{
    private TMP_Dropdown topingOptions;
    public Image topings;

    public Sprite[] topingsBase;

    void Start()
    {
        topingOptions = GetComponent<TMP_Dropdown>();
        topings = GameObject.Find("Topings").GetComponent<Image>();
    }

    public void ChangeToping()
    {
        switch (topingOptions.value)
        {
            case 0:
                topings.sprite = topingsBase[0];
                break;
            case 1:
                topings.sprite = topingsBase[1];
                break;
            case 2:
                topings.sprite = topingsBase[2];
                break;
        }
    }

}
