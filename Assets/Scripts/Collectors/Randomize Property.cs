using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeProperty : MonoBehaviour
{
    public int leftChoice;
    public int rightChoice;
    public int middleChoice;

    public void re_randomize()
    {
        leftChoice = Random.Range(0, 10);
        rightChoice = Random.Range(0, 10);
        if (PublicVariables.dash_enable == false){
            middleChoice = 10;
        } else {
            middleChoice = Random.Range(0,10);
        }
        for (int i = 1; i > 0; i++)
        {
            if (leftChoice == rightChoice)
            {
                rightChoice = Random.Range(0, 10);
            } else if (leftChoice == middleChoice) {
                middleChoice = Random.Range(0,10);
            } else if (rightChoice == middleChoice){
                middleChoice = Random.Range(0,10);
            } else {
                break;
            }
        }

        Debug.Log("Left value is" + leftChoice);
        Debug.Log("middle value is" + middleChoice);
        Debug.Log("Right value is" + rightChoice);
    }

}
