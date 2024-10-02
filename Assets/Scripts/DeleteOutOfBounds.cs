using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOutOfBounds : MonoBehaviour
{
    private float zBounds = 25.5f;
    private float xBounds = 25.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xBounds) {
            Destroy(gameObject);
        }
        if (transform.position.x < -xBounds) {
            Destroy(gameObject);
        }
        if (transform.position.z > zBounds) {
            Destroy(gameObject);
        }
        if (transform.position.z < -zBounds) {
            Destroy(gameObject);
        }
    }
}
