using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollide : MonoBehaviour
{
    // Start is called before the first frame update
    private float xRange = 23.5f;
    private float zRange = 23.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
    if (other.tag == "Wall") {
        if (other.transform.position.x > 0) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (other.transform.position.x < 0) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (other.transform.position.z > 0) {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (other.transform.position.z < 0) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
    }


    }
}
