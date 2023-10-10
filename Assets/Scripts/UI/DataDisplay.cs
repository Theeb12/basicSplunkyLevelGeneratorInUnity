using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataDisplay : MonoBehaviour
{
    [SerializeField] Text CurrentHealthText;
    [SerializeField] Text MaxHealthText;
    [SerializeField] Text SpeedPowerText;
    [SerializeField] Text JumpPowerText;
    [SerializeField] Text AttackDmgText;
    [SerializeField] Text AttackcdText;
    [SerializeField] Text DashPowerText;
    [SerializeField] Text DashcdText;

    void Update()
    {
        CurrentHealthText.text = PublicVariables.player_currentHealth.ToString();
        MaxHealthText.text = PublicVariables.player_maxHealth.ToString();
        SpeedPowerText.text = PublicVariables.player_speed.ToString();
        JumpPowerText.text = PublicVariables.player_jump.ToString();
        AttackDmgText.text = PublicVariables.attackDmg.ToString();
        AttackcdText.text = PublicVariables.attackcd.ToString("#.00") + " sec";
        if (PublicVariables.dash_enable)
        {
            DashPowerText.text = PublicVariables.dashLimit.ToString("#.00") + " sec";
            DashcdText.text = PublicVariables.dashcd.ToString("#.00")  + " sec";
        } else {
            DashPowerText.text = "N/A";
            DashcdText.text = "N/A";
        }
    }
}
