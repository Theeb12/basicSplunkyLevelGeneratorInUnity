using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read_Display : MonoBehaviour
{
    [SerializeField] Text LeftText;
    [SerializeField] Text MiddleText;
    [SerializeField] Text RightText;
    [SerializeField] PlayerMovement player;
    [SerializeField] GameObject myself;


    void Update()
    {
        DisplayWord(LeftText, player.left);
        DisplayWord(MiddleText, player.middle);
        DisplayWord(RightText, player.right);
    }

    private void DisplayWord(Text target, int rand)
    {
        if (rand == -1)
        {
            target.text = "Some bug happened!";
        }
        if (rand == 0)
        {
            target.text = "New Life \n Gain 1 maximum health and heal yourself by 1";
        }
        if (rand == 1)
        {
            target.text = "Reaction \n Increase your speed slightly";
        }
        if (rand == 2)
        {
            target.text = "Jump \n Increase your jump power slightly";
        }
        if (rand == 3)
        {
            target.text = "Quick Magic \n Decrease your dash cooldown slightly";
        }
        if (rand == 4)
        {
            target.text = "Super Power \n Increase your dash power slightly";
        }
        if (rand == 5)
        {
            target.text = "Hunter \n Decrease your attack cooldown slightly";
        }
        if (rand == 6)
        {
            target.text = "Fire Everything \n Increase your attack damage slightly";
        }
        if (rand == 7)
        {
            target.text = "Impact \n Lost 1 current health to gain more running speed";
        }
        if (rand == 8)
        {
            target.text = "Trade off \n You almost lose your speed, but you gain unlimited dash power";
        }
        if (rand == 9)
        {
            target.text = "Patiently \n Increase your attack cooldown, but increase your attack damage";
        }
        if (rand == 10)
        {
            target.text = "Learn Magic \n Unlock the Dash ability";
        }
    }

    public void IChooseLeft()
    {
        takeAction(player.left);
        myself.SetActive(false);
        Time.timeScale = 1f;
    }
    public void IChooseMiddle()
    {
        takeAction(player.middle);
        myself.SetActive(false);
        Time.timeScale = 1f;
    }
    public void IChooseRight()
    {
        takeAction(player.right);
        myself.SetActive(false);
        Time.timeScale = 1f;
    }

    private void takeAction(int input)
    {
        if (input == -1)
        {
            Debug.Log("Warning: Bugs!");
        }
        if (input == 0)
        {
            //Gain 1 maximum health and heal yourself by 1
            PublicVariables.player_maxHealth += 1;
            PublicVariables.player_currentHealth += 1;
        }
        if (input == 1)
        {
            //Increase your speed slightly
            PublicVariables.player_speed += 1;
        }
        if (input == 2)
        {
            //Increase your jump power slightly
            PublicVariables.player_jump += 1;
        }
        if (input == 3)
        {
            //Decrease your dash cooldown slightly
            if (PublicVariables.dashcd > 1)
            {
                PublicVariables.dashcd -= 1;
            }
        }
        if (input == 4)
        {
            //Increase your dash power slightly
            PublicVariables.dashLimit += 0.1f;
        }
        if (input == 5)
        {
            //Decrease your attack cooldown slightly
            if (PublicVariables.attackcd > 1)
            {
                PublicVariables.attackcd -= 1;
            }
        }
        if (input == 6)
        {
            //Increase your attack damage slightly
            PublicVariables.attackDmg += 1;
        }
        if (input == 7)
        {
            //Lost 1 current health to gain more running speed
            if (PublicVariables.player_currentHealth > 1)
            {
                PublicVariables.player_currentHealth -= 1;
            }
            PublicVariables.player_speed += 3;
        }
        if (input == 8)
        {
            //You almost lose your speed, but you gain unlimited dash power
            PublicVariables.player_speed = 1;
            PublicVariables.dashcd = 0.5f;
        }
        if (input == 9)
        {
            //Increase your attack cooldown, but increase your attack damage
            PublicVariables.attackcd += 2;
            PublicVariables.attackDmg += 2;
        }
        if (input == 10)
        {
            //Unlock the Dash ability
            PublicVariables.dash_enable = true;
        }
    }
}
