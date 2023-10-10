using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateManager : MonoBehaviour
{
    public void ReloadCurrentScene()
    {
        //Reset Health
        PublicVariables.player_currentHealth = 5;
        PublicVariables.player_maxHealth = 5;

        //Reset Dash
        PublicVariables.dash_enable = false;
        PublicVariables.dashcd = 8;
        PublicVariables.dashLimit = 0.1f;

        //Reset Movement
        PublicVariables.player_speed = 5;
        PublicVariables.player_jump = 5;

        //Reset Player Attack
        PublicVariables.attackcd = 4;
        PublicVariables.attackDmg = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ChangeSceneByName(string name)
    {
        if (name != null)
        {
            SceneManager.LoadScene(name);
        }
    }
}
