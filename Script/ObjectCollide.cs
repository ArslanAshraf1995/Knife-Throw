using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollide : MonoBehaviour
{
    public static int countCollisions = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Destroy the wooden log after some knife hit.
        if(countCollisions == 6)
		{
            Destroy(gameObject);
        }
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
        //Detect if knife hits the wooden log or not. 
		if(collision.collider.tag == "knife")
		{
            countCollisions++;
		}
	}
	
}
