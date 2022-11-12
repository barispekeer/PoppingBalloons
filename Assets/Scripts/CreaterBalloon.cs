using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaterBalloon : MonoBehaviour
{
    public GameObject Balloon;
    void Start()
    {
        InvokeRepeating("AddBalloon", 0f, 1.2f);
    }
    void AddBalloon()
    {
        GameObject newBalloon = Instantiate(Balloon, new Vector3(Random.Range(-2.5f, 2.5f), -6, 0), transform.rotation);
    }
}
