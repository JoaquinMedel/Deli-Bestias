using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int coins;
    public TMP_Text coinsText;

    // Con esto se agregan las monedas
    public void AddCoins(int amount)
    {
        coins += amount;
        PlayerPrefs.SetInt("Coins", coins); // Esto se usa para guardar el valor de las monedas
        UpdateCoinsText();
    }

    // Con esto obtenemos la cantidad de monedas
    public int GetCoins()
    {
        return coins;
    }

    // Se inician las monedas que se guardaron
    private void Start()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            coins = PlayerPrefs.GetInt("Coins");
        }
        else
        {
            coins = 0;
        }

        UpdateCoinsText();
    }

    private void UpdateCoinsText()
    {
        coinsText.text = coins.ToString(); // Actualizar el texto con la cantidad de monedas
    }
}
