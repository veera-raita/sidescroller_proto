using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {       //if colliding with obstacle, destroy
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
        }
    }
}
