using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonControl : MonoBehaviour
{
    public GameObject explosion;
    Rigidbody2D rigi;
    float speed;
    GameController gc;
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        speed = Random.Range(4f, 12f);
        gc = GameObject.Find("Admin").GetComponent<GameController>();
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void OnMouseDown()
    {
        GameObject newExplo = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(newExplo, 0.34f);
        gc.AddScore();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Finish"))
        {
            gc.bombBall--;
            gc.balloonTxt.text = "BALLOON: " + gc.bombBall;
            Destroy(gameObject);
        }
    }
}
