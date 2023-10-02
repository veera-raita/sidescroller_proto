using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Obstacles;
    public PlayerController playerControllerScript;

    private void SpawnRandOne()
    {
        if (playerControllerScript.GameOver == false)
        {
            //get random int
            int rnd = Random.Range(0, Obstacles.Length);
            //instantiate gobj
            Instantiate(Obstacles[rnd], new Vector3(23, 0, 0), Obstacles[rnd].transform.rotation);
            Invoke("SpawnRandOne", Random.Range(0.7f, 1.3f));   //invoke same thing again with random delay
        }
    }
    // Start is called before the first frame update
    void Start()
    {       //start spawner function, check playercontroller to see if game over
        Invoke("SpawnRandOne", 3);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
