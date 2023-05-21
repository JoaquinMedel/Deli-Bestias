using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEditor;

public class UiManager : MonoBehaviour
{
    public RectTransform flappyBird;
    public CanvasGroup barButtom;
    public GameObject bloqBarra;

    public void chooseGame(float posX)
    {
        flappyBird.DOAnchorPos(new Vector2(-4000, 0), 0f);
        barButtom.DOFade(0, 0f);
        bloqBarra.SetActive(false);
    }
    
    

}

