using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public int coinsToCollect = 0;
    private GameManager gameManager;
    public TMP_Text coinsText2;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.AddCoins(coinsToCollect);
        UpdateCoinsText(); 
    }

    private void UpdateCoinsText()
    {
        coinsText2.text = gameManager.GetCoins().ToString();
    }
}
