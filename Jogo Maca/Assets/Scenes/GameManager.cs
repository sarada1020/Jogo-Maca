using System.Collections;
using System.Collections.Generic;
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

    void Awake()
    {
        instance = this;
        screenBounds = (Vector2)Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)) + new Vector3(-1, 1);
    }

}
