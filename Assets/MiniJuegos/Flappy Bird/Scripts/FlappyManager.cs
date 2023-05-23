using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyManager : MonoBehaviour
{
    private GameManager gameManager0;


    void Start()
    {
        gameManager0 = FindObjectOfType<GameManager>();
    }
}
