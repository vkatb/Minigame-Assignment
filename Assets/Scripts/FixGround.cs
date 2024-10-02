using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixGround : MonoBehaviour
{
    private float top = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target") {
            other.transform.Translate(Vector3.up * top);
        }
        }
}
