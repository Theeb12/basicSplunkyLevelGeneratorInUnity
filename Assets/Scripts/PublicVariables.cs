using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVariables : MonoBehaviour
{
    //Player Health
    public static float player_currentHealth = 5;
    public static float player_maxHealth = 5;

    //Player Dash
    public static bool dash_enable = true;
    public static float dashcd = 3;
    public static float dashLimit = 0.1f;

    //Player Movement
    public static int player_speed = 5;
    public static int player_jump = 5;

    //Player Attack
    public static float attackcd = 3;
    public static int attackDmg = 1;
}
