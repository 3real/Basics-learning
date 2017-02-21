using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        zombie zombie = new zombie();
        player player = new player();
        

        player.TakeDamage(zombie.Attack());
        player.TakeDamage(zombie.AcidPukeAttack());

        player.Die();

        zombie[] zombies = new zombie[100];

        for (int i = 0; i < zombies.Length; i++)
        {
            zombies[i] = new zombie();
            Debug.Log("Creating Zombie #:" + i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
