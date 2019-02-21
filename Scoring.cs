

/*This program features a scoring method that is depedent on player collisions
The player must collide with specifically tagged colliders to aquire points
The points are visible on a UI Canvas which also features a countdown timer
UI elements for score and time left must be created and configured in Unity
For reference on how to use this script please consult the Scoring document
for any questions regarding how to use this script please contact kai02916@gmail.com
Created by: Kathrine von Friedl for the University of Waterloo's Ideas Clinic*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private float timeLeft = 60;
    public GameObject timeLeftUI;
    public GameObject scoreUI;
    static int playerScore = 0;


    void Start()
    {
        UpdateScore(playerScore);
    }

    void UpdateScore(int addedValue)
    {
        playerScore += addedValue;
        scoreUI.gameObject.GetComponent<Text>().text = "Score: " + playerScore;
    }

    void OnTriggerEnter(Collider other)
    {
        if (timeLeft > 0)
        {
            switch (other.tag)
            {
                case "point10":
                    UpdateScore(10);
                    break;
                case "point100":
                    UpdateScore(100);
                    break;
                case "point1000":
                    UpdateScore(1000);
                    break;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object Exited the trigger");
    }

    void Update()
    {
        //end of new code

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
        }
        else
            timeLeftUI.gameObject.GetComponent<Text>().text = ("Time is up!");
    }
}
