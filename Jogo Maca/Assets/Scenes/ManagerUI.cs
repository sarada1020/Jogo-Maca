using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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

    


}
