using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listtimebaby : MonoBehaviour {

    public GameObject cubePrefab;

    GameObject[] cubes = new GameObject[5];

    float spacer = 0.5f;

    Color[] colours = { Color.grey, Color.blue, Color.yellow, Color.red, Color.green };

    // Use this for initialization
    void Start () {

        for (int i = 0; i < cubes.Length; i++)
        {

            GameObject cube = Instantiate(cubePrefab);
            cubes[i] = cube;
            cube.transform.position = new Vector3(i + (spacer * i) , cube.transform.position.y);
            Renderer rend = cube.GetComponent<Renderer>();
            rend.material.color = colours[i];

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
