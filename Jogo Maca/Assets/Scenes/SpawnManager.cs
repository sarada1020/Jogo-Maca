using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject redApple, greenApple, goldenApple;
    float timer;
    float initialTime = 1.2f;
    int appleType;
    void Spawn()
    {
        if (timer <= 0)
        {
            int appleType = Random.Range(0, 101);

            if (appleType > 90)
            {
                Instantiate(goldenApple, new Vector3(Random.Range(-GameManager.Instance.ScreenBounds.x, GameManager.Instance.ScreenBounds.x), GameManager.Instance.ScreenBounds.y, 0), Quaternion.identity);
            }
            else if (appleType > 60)
            {
                Instantiate(greenApple, new Vector3(Random.Range(-GameManager.Instance.ScreenBounds.x, GameManager.Instance.ScreenBounds.x), GameManager.Instance.ScreenBounds.y, 0), Quaternion.identity);
            }
            else if (appleType < 60)
            {
                Instantiate(goldenApple, new Vector3(Random.Range(-GameManager.Instance.ScreenBounds.x, GameManager.Instance.ScreenBounds.x), GameManager.Instance.ScreenBounds.y, 0), Quaternion.identity);
            }
            if (initialTime > 0.8)
            {
                initialTime -= 0.05f;
            }
            timer = initialTime;
        }
        else { timer -= Time.deltaTime; }
    }
}
