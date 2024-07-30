using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private Vector2 screenBounds;
    private int score;
    private int lifes = 3;

    public static GameManager Instance { get => instance; }
    public Vector2 ScreenBounds { get => screenBounds; }
    public int Lifes { get => lifes; }
    public int Score { get => score; set => score = value; }

    void Awake()
    {
        instance = this;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0)) + new Vector3(-1, 1, 0);
    }
    public void LoseLife()
    {
        lifes -= 1;
        ManagerUI.instance.UpdateLifeText();

        if (lifes == 0)
        {
            if (Score > PlayerPrefs.GetInt("Record", 0))
            {
                PlayerPrefs.SetInt("Record", Score);
            }
            Time.timeScale = 0;
            ManagerUI.instance.GameOver();
        }

    }
}
