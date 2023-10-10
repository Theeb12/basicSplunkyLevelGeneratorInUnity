using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{


    private bool dead;

    [Header("IFrames")]
    [SerializeField] private float IframeDuration;
    [SerializeField] private int numberofFlashes;
    private SpriteRenderer spriteRender;

    [Header("Audio")]
    [SerializeField] public AudioSource hurt;
    //[SerializeField] public AudioSource Death;

    private void Awake()
    {
        //dead = false;
        spriteRender = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(int dmg)
    {
        PublicVariables.player_currentHealth -= dmg;
        if (PublicVariables.player_currentHealth < 0)
        {
            PublicVariables.player_currentHealth = 0;
        }

        if (PublicVariables.player_currentHealth > 0)
        {
            //player take damage
            //Debug.Log("take damage");
            hurt.Play();
            StartCoroutine(Invulnerability());
        } else {
            if (!dead)
            {
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
                PlayerDead();
                //Debug.Log("dead!");
            }
            //Debug.Log("dead already");
        }
    }

    private void PlayerDead()
    {
        hurt.Play();
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }

    private IEnumerator Invulnerability()
    {
        Physics2D.IgnoreLayerCollision(6, 7, true);
        for (int i = 0; i < numberofFlashes; i++)
        {
            spriteRender.color = new Color(1,0,0, 0.5f);
            yield return new WaitForSeconds(IframeDuration / (numberofFlashes * 2));
            spriteRender.color = Color.white;
            yield return new WaitForSeconds(IframeDuration / (numberofFlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(6, 7, false);
    }

    public void reborn()
    {
        PublicVariables.player_currentHealth = PublicVariables.player_maxHealth;
    }
}
