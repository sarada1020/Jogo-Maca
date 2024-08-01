using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rigidbody2D;

    private void Update()
    {
        if (transform.position.y <= -GameManager.Instance.ScreenBounds.y) ;
        {
            GameManager.Instance.LoseLife();
            Destroy(gameObject);

        }

        rigidbody2D.velocity = new Vector2(0, -speed);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"));
        {

        }

    }

}
