using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private int points;
    private int pointsMinigame;
    private bool firstPlay = true;
    private int _pointsMinigame = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.root.gameObject);
            
            if (!SceneManager.GetSceneByName("0Null").isLoaded)
            {
                SceneManager.LoadScene("0Null" , LoadSceneMode.Additive);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void AddPoints()
    {
        points += _pointsMinigame;
        _pointsMinigame = 0;
    }

    public static GameManager Instance
    {
        get { return instance; }
    }

    public int Points
    {
        get { return points + GameManager.instance.pointsMinigame; }
        set { points = value; }
    }

    public int PointsMinigame

    {
        get { return pointsMinigame; }
        set { pointsMinigame = value; }
    }

    public bool FirstPlay
    {
        get { return firstPlay; }
        set { firstPlay = value; }
    }

    public void ResetPointsMinigame()
    {
        pointsMinigame = 0;
    }

    public int PointsMinijuegos { get; set; }
}