using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleCollide : MonoBehaviour
{
    // Start is called before the first frame update
    private float capsuleRotate = 3.0f;
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
        if (other.tag == "Projectile") {
            transform.Rotate(Vector3.back * capsuleRotate);
            Destroy(other.gameObject);
        }
    }
}
