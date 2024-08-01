using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ManagerUI : MonoBehaviour
{
    public static ManagerUI instance;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI recordText;
    [SerializeField] TextMeshProUGUI lifeText;
    [SerializeField] GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = GameManager.instance.Score.ToString(); 
    }

    public void UpdateLifeText()
    {
        lifeText.text = GameManager.instance.Lifes.ToString();
    }

    public void GameOver()
    {
        recordText.text = "Record:" + PlayerPrefs.GetInt("Record");

        gameOverPanel.SetActive(true);

    }

    public void Reload()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene("SampleScene");
    }

}
