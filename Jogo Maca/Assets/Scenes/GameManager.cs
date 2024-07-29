using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private Vector2 screenBounds;
    private int score;
    private int lifes = 3;

    public static GameManager Instance { get => instance;}
    public Vector2 ScreenBounds { get => screenBounds;}
    public int Score { get => score;}
    public int Lifes { get => lifes;}
}
