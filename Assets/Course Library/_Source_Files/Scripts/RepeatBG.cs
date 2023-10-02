using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    public float Width = 0;
    public Vector3 StartPos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {       //define stuff
        StartPos = transform.position;
        Width = GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {       //thing to make background repeat
        if (transform.position.x < StartPos.x - Width / 2.0f)
        transform.position = StartPos;
    }
}
