using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth : MonoBehaviour
{
    public int maxHealt = 3;
    public int currentHealt;

    // Start is called before the first frame update
    void Start()
    {
        currentHealt = maxHealt;
    }

    public void TakeDamage(int amount)
    {
        currentHealt -= amount;
        if (currentHealt <= 0)
        {
            //We are dead
            //Play dead animation
            //Show GameOver screen
        }
    }

    public void Heal(int amount)
    {
        currentHealt += amount;
        if (currentHealt > 3)
        {
            currentHealt = maxHealt;
        }
    }
}
