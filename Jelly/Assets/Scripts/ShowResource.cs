using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowResource : MonoBehaviour
{
    public Sprite icon;
    public int quantity;

    private TextMeshProUGUI num;
    private Image mini;

    void Start()
    {
        mini = gameObject.GetComponentInChildren<Image>();
        mini.sprite = icon;

        num = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        num.text = quantity.ToString();
    }
}
