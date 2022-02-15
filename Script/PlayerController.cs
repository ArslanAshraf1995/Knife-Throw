using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float HorzinotalInput;
    public float speed = 20.0f;
    public float xRange = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        HorzinotalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * Time.deltaTime * speed * HorzinotalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate the prefab object when key press
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
