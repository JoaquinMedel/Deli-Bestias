using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;
using UnityEngine.UI;

public class MGManager : MonoBehaviour
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
