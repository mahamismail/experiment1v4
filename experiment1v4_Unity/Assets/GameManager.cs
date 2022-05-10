using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PlayerLives = 3;

    public GUISkin layout;

    GameObject theBall;

    // Start is called before the first frame update
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
        
    }

    public static void Score (string wallID) {
    if (wallID == "BottomWall")
        {
            PlayerLives--;
        }
    }

    void OnGUI () {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerLives);
        if (GUI.Button(new Rect(Screen.width / 2 - 60, 5, 120, 53), "RESTART"))
        {
            PlayerLives = 3;
            theBall.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
        }
        if(PlayerLives == 0)
        {
            GUI.Button(new Rect(Screen.width / 2 - 50, 80, 100, 100), "You Lose!");
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
