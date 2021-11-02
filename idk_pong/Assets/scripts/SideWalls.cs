using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{
   public GameObject Manager;
    public GameObject Ball;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Ball")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            Manager.SendMessage("fortnite");
            Ball.SendMessage("ResetBall");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Manager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
