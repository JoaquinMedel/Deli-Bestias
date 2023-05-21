using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyManager : MonoBehaviour
{
    public int coinsEarnedInMinigame;
    private GameManager gameManager0;


    void Start()
    {
        gameManager0 = FindObjectOfType<GameManager>();
    }

    public void AddCoinsToGame()
    {
        gameManager0.AddCoins(coinsEarnedInMinigame);
    }

}
