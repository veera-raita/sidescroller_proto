using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public int speed = 10;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {       //get playercontroller script to check if game over
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {       //if game isn't over, move stuff left
        if (playerControllerScript.GameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
