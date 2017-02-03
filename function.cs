using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class function : MonoBehaviour {

    int health = 100;
    int attackpower = 25;
    bool shieldOn = true;
    int shieldAmount = 15;


    void Start()
    {
        Debug.Log("Health at start: " + health);
    }

    public void Attack() {
        int damageToInflict = GetAttackDamage(shieldOn, shieldAmount, attackpower);
        health -= damageToInflict;
        Debug.Log("Health after attack: " + health);
    }

    public void Heal()
    {
        int healthamount = GetRandomNumber();
        health += healthamount;

        Debug.Log("You have recieved " + healthamount + "health");
        Debug.Log("You now have " + health + "health");
    }

    private int GetAttackDamage(bool isShieldOn, int theShieldAmount, int theAttackPower)
    {
        int damage = 0;

        if (isShieldOn)
        {
            damage = theAttackPower - (int)((float)theShieldAmount * 0.10f);
        }
        else
        {
            damage = theAttackPower;
        }


        return damage;
    }


    private int GetRandomNumber()
    {
        return Random.Range(2, 10);
    }
}
