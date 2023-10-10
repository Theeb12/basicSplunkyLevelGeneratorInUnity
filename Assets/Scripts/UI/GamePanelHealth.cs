using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePanelHealth : MonoBehaviour
{
    [SerializeField] Text healthText;

    void Update()
    {
        healthText.text = "Health: " + PublicVariables.player_currentHealth.ToString();
    }
}
