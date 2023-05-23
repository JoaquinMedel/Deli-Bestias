using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEscenas : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject iniciandoJuego;
    public GameObject perdiendoJuego;

    private void Start()
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
        iniciandoJuego.SetActive(true);
    }

    public void Iniciar()
    {
        gameOverCanvas.SetActive(false);
        iniciandoJuego.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        perdiendoJuego.SetActive(true);
        Time.timeScale = 0;
    }


}
