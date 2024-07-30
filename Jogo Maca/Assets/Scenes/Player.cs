using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2D;
    float direction;
    float speed = 20;

    void Move()
    {
        rigidbody2D.velocity = new Vector2(speed * direction, 0);

        if (-GameManager.Instance.ScreenBounds.x > transform.position.x)
        {
            transform.position = new Vector2(-GameManager.Instance.ScreenBounds.x, transform.position.y);
        }
        else if (transform.position.x > GameManager.Instance.ScreenBounds.x)
        {
            transform.position = new Vector2(GameManager.Instance.ScreenBounds.x, transform.position.y);
        }
    }
    private void Update()
    {
        direction = Input.GetAxis("Horizontal");
        Move();
    }
}
