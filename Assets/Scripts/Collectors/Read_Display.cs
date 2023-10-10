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
    [SerializeField] Text LeftTitle;
    [SerializeField] Text MiddleTitle;
    [SerializeField] Text RightTitle;


    void Update()
    {
        DisplayWord(LeftText, player.left);
        DisplayWord(MiddleText, player.middle);
        DisplayWord(RightText, player.right);
        DisplayTitle(LeftTitle, player.left);
        DisplayTitle(MiddleTitle, player.middle);
        DisplayTitle(RightTitle, player.right);
    }

    private void DisplayTitle(Text target, int rand)
    {
        if (rand == -1)
        {
            target.text = "Some bug happened!";
        }
        if (rand == 0)
        {
            target.text = "New Life";
        }
        if (rand == 1)
        {
            target.text = "Action Time";
        }
        if (rand == 2)
        {
            target.text = "JUMP!";
        }
        if (rand == 3)
        {
            target.text = "Quick Magic";
        }
        if (rand == 4)
        {
            target.text = "Deep Think";
        }
        if (rand == 5)
        {
            target.text = "Hunter Feeling";
        }
        if (rand == 6)
        {
            target.text = "Fire Everything";
        }
        if (rand == 7)
        {
            target.text = "Hurt Impact";
        }
        if (rand == 8)
        {
            target.text = "Trade off";
        }
        if (rand == 9)
        {
            target.text = "Patient Accurate";
        }
        if (rand == 10)
        {
            target.text = "Learn new Magic";
        }
    }

    private void DisplayWord(Text target, int rand)
    {
        if (rand == -1)
        {
            target.text = "Some bug happened!";
        }
        if (rand == 0)
        {
            target.text = "Gain 1 maximum health and heal yourself by 1";
        }
        if (rand == 1)
        {
            target.text = "Increase your speed slightly";
        }
        if (rand == 2)
        {
            target.text = "Increase your jump power slightly";
        }
        if (rand == 3)
        {
            target.text = "Decrease your dash cooldown slightly";
        }
        if (rand == 4)
        {
            target.text = "Increase your dash power slightly";
        }
        if (rand == 5)
        {
            target.text = "Decrease your attack cooldown slightly";
        }
        if (rand == 6)
        {
            target.text = "Increase your attack damage slightly";
        }
        if (rand == 7)
        {
            target.text = "Lost 1 current health to gain more running speed";
        }
        if (rand == 8)
        {
            target.text = "You almost lose your speed, but you gain unlimited dash power";
        }
        if (rand == 9)
        {
            target.text = "Decrease your attack frequency, but increase your attack damage";
        }
        if (rand == 10)
        {
            target.text = "Unlock the Dash ability! 'Press Z'";
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
            PublicVariables.player_speed += 2;
        }
        if (input == 2)
        {
            //Increase your jump power slightly
            PublicVariables.player_jump += 2;
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
            PublicVariables.player_speed += 4;
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
