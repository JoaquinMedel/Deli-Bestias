using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PintsDisplay : MonoBehaviour
{

    private TextMeshProUGUI pointsText;
    private GameManager gameManager;

    private void Start()
    {
        pointsText = GetComponent<TextMeshProUGUI>();
        gameManager = GameManager.Instance;
        UpdatePointsUI();
    }

    private void UpdatePointsUI()
    {
        pointsText.text = gameManager.Points.ToString();
    }
}
