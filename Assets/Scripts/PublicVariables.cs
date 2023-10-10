using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVariables : MonoBehaviour
{
    //Player Health
    public static int player_currentHealth = 5;
    public static int player_maxHealth = 5;

    //Player Dash
    public static bool dash_enable = false;
    public static float dashcd = 8;
    public static float dashLimit = 0.1f;

    //Player Movement
    public static int player_speed = 5;
    public static int player_jump = 5;

    //Player Attack
    public static float attackcd = 4;
    public static int attackDmg = 1;
}
