using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string heroName = "Thanos";
        string equippedWeapon = "Infinity Gauntlet";
        string favouriteFurniture = "Throne";

        string favouritePlanet;

        favouritePlanet = "Earth";

        Debug.Log(favouritePlanet);
        Debug.Log(heroName);
        Debug.Log(equippedWeapon);
        Debug.Log(favouriteFurniture);
        Debug.Log(equippedWeapon.ToUpper());

        int hp = 100;
        float shieldPower = 76.5f;
        int laserDamage = 30;
        double actualDamagePercent = 0.05;
        int actualDamage = (int)(laserDamage * actualDamagePercent);

        hp -= actualDamage;

        shieldPower -= (laserDamage - actualDamage);

        Debug.Log("HP: " + hp);
        Debug.Log("Shield Power: " + shieldPower);

        int slices = 10 / 5;
        print(slices);

        int newDamage = 10 / 3;

        print(newDamage);

        int newDamageRemainder = 10 % 3;

        print("10 divided by 3 is equal to" + newDamage + "with a remainder" + newDamageRemainder);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
