using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitHealth : MonoBehaviour
{
    public int maxHealth = 6;
    public int currentHealth;

    public Image[] heartImages;
    public Sprite fullHeartSprite;
    public Sprite halfHeartSprite;
    public Sprite emptyHeartSprite;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateUI();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            //We are dead
            //Play dead animation
            //Show GameOver screen
        }
        UpdateUI();
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateUI();
    }

    void UpdateUI()
    {
        int numHearts = currentHealth / 2;
        bool hasHalfHeart = currentHealth % 2 == 1;

        for (int i = 0; i < heartImages.Length; i++)
        {
            if (i < numHearts)
            {
                heartImages[i].sprite = fullHeartSprite;
            }
            else if (hasHalfHeart)
            {
                heartImages[i].sprite = halfHeartSprite;
                hasHalfHeart = false;
            }
            else
            {
                heartImages[i].sprite = emptyHeartSprite;
            }

            heartImages[i].enabled = i < maxHealth / 2;
        }
    }
}
