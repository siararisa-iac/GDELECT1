using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField]
    private Material targetMaterial;
    [SerializeField]
    private Color targetColor;

    private Image display;
    private void Awake()
    {
        display = GetComponent<Image>();
        display.color = targetColor;
    }

    public void ChangeColor()
    {
        targetMaterial.color = targetColor;
    }



}
