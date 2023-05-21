using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToggle : MonoBehaviour
{
   [SerializeField] private RectTransform uiHandleRectTransform;
   [SerializeField] private Color backgroundActiveColor;
   [SerializeField] private Color handleActiveColor;

   Image backgroundImage, handleImage;
   private Color backgroundDefaultColor, handleDefaultColor;

    private Toggle toogle;

    private Vector2 handlePosition;

    private void Awake()
    {
        toogle = GetComponent<Toggle>();

        handlePosition = uiHandleRectTransform.anchoredPosition;
        backgroundImage = uiHandleRectTransform.parent.GetComponent<Image>();
        handleImage = uiHandleRectTransform.GetComponent<Image>();

        backgroundDefaultColor = backgroundImage.color;
        handleDefaultColor = handleImage.color;
        
        
        toogle.onValueChanged.AddListener(OnSwitch);
        if (toogle.isOn)
        {
            OnSwitch(true);
        }
    }

    void OnSwitch(bool on)
    {
        uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition;
        backgroundImage.color = on ? backgroundActiveColor : backgroundDefaultColor;
        handleImage.color = on ? handleActiveColor : handleDefaultColor;
    }

    private void OnDestroy()
    {
        
    }
}
