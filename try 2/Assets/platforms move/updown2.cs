using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown2 : MonoBehaviour
{

    public bool isgoingup = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isgoingup)
        {
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        }

        // Move the object upward in world space 1 unit/second.

        if (transform.position.y >= 0.77)
        {
            isgoingup = false;
        }
        else if (transform.position.y <= -0.78)
        {
            isgoingup = true;
        }


    }
}
