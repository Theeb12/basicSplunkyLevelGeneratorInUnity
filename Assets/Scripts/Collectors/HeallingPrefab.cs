using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeallingPrefab : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            if (PublicVariables.player_maxHealth != PublicVariables.player_currentHealth)
            {
                PublicVariables.player_currentHealth += 1;
            }
        }
    }
}
