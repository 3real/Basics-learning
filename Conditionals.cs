using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    int PlayerAlphaTowersRemaining = 2;
    int PlayerBravoTowersRemaining = 2;
    bool PlayerAlphaMainTowersDestroyed = false;
    bool PlayerBravoMainTowersDestroyed = false;
    float timer = 200;
    // Use this for initialization
    void Start () {
        if (PlayerAlphaMainTowersDestroyed || PlayerBravoMainTowersDestroyed)
        {
            if (PlayerAlphaMainTowersDestroyed)
            {
                Debug.Log("Player Bravo wins!!");
            }
            else { Debug.Log("Player Alpha wins!!"); }
        }
        else if (timer <= 0)
        {
         if (PlayerAlphaTowersRemaining < PlayerBravoTowersRemaining)
            {
                Debug.Log("Player Bravo wins!!");
            }   
         else if (PlayerBravoTowersRemaining < PlayerAlphaTowersRemaining)
            {
                Debug.Log("Player Alpha wins!!");
            }
         else
            {
                Debug.Log("The game was a draw");
            }
        }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
