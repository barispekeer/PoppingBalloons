using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaterBalloon : MonoBehaviour
{
    public GameObject Balloon;
    GameController gameC;
    void Start()
    {
        gameC = GameObject.Find("Admin").GetComponent<GameController>();
        if (gameC.timer > 0)
        {
            InvokeRepeating("AddBalloon", 0f, 1.2f);
        }
        
    }
    public void AddBalloon()
    {
        GameObject newBalloon = Instantiate(Balloon, new Vector3(Random.Range(-2.5f, 2.5f), -6, 0), transform.rotation);
    }
    public void CloseExplosion()
    {
        CancelInvoke(nameof(AddBalloon));
    }
}
