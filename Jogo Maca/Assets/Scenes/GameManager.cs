using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;

    private Vector2 screenBounds;
    private int score;
    private int lifes = 3;

    public static GameManager Instance { get => Instance; }
    public Vector2 ScreenBounds { get => screenBounds; }
    public int Lifes { get => lifes; }

    void Awake()
    {
        Instance = this;
        screenBounds = New Vector3 (point.position.x = -1, point.position.y = 1 + mainCamera.ScreenToWorldPoint(new Vector3 point.position.x = Screen.width, point.position.y = Screen.heigth));
    }
    public void LoseLife()
    {
        lifes -= 1;
        ManagerUI.instance.UpdateLifeText();
        if (lifes == 0)
        {
            if (score > PlayerPrefs.GetInt("Record", 0))
            {
                PlayerPrefs.SetInt("Record", score);
            }
            Time.timeScale = 0;
            ManagerUI.instance.GameOver();
        }

    }
}
