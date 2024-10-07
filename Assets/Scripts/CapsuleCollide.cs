using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleCollide : MonoBehaviour
{
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
        if (other.tag == "Player") {
            Destroy(gameObject);
        }
        if (other.tag == "Target") {
            Destroy(other.gameObject);
        }
        if (other.tag == "Projectile") {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
