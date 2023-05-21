using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager1 : MonoBehaviour
{
    public RectTransform panelController, options;

    public void ChoosePanel(float posX)
    {
        panelController.DOAnchorPosX(posX, .25f);
    }

    private void Start()
    {
        ChoosePanel(0);
    }

    public void Options()
    {
        options.DOAnchorPos(new Vector2(0, 0),0.40f);
    }

    public void CloseOptions()
    {
        options.DOAnchorPos(new Vector2(0, 820),0.40f);
    }
}
