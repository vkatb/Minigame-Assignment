using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyTarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DestroyTarget()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}
