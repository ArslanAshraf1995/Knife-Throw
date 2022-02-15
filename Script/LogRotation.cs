using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogRotation : MonoBehaviour
{
    public float time = 0;
    public float speed = 250f;
    public GameObject knife;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Count the time of rotation
        time += Time.deltaTime;

        //Rotate the object Clockwise
        transform.Rotate(Vector3.back * speed * Time.deltaTime);

        //Set a rotation speed duration
        if ((int)time % 2 == 0)
        {
            speed = Random.Range(200f, 450f);
        }
        else if ((int)time % 3 == 0)
        {
            speed = Random.Range(400f, 600f);
        }

    }
}

