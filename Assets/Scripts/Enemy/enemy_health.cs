using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_health : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private float startingHealth;
    [SerializeField] public AudioSource hurt;
    private float currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float dmg)
    {
        currentHealth = Mathf.Clamp(currentHealth - dmg, 0, startingHealth);
        hurt.Play();
        if (currentHealth > 0)
        {
            //enemy take damage
            //Debug.Log("hurt!");
            anim.SetTrigger("hurt");
            
        } else {
            anim.SetTrigger("die");
            //Debug.Log("enemy is dead");
        }
    }

    public void Dead()
    {
        if (gameObject != null)
            hurt.Play();
            Destroy(gameObject);
    }
}
