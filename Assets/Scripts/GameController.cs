using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public CreaterBalloon cb;
    public TMP_Text timeTxt, balloonTxt;
    public float timer = 5;
    public int bombBall = 0;
    public Image finishPanel;
    public GameObject bombEffect;
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timeTxt.text = "TIME: " + (int)timer;
        }
        else
        {
            cb.CloseExplosion();
            GameObject[] othersBall = GameObject.FindGameObjectsWithTag("Player");
            for (int i = 0; i < othersBall.Length; i++)
            {
                Instantiate(bombEffect, othersBall[i].transform.position, othersBall[i].transform.rotation);
                Destroy(othersBall[i]);
            }
            finishPanel.gameObject.SetActive(true);
        }
    }
    public void AddScore()
    {
        bombBall++;
        balloonTxt.text = "BALLOON: " + bombBall;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
