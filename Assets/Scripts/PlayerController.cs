using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float rotationalInput;
    private float moveSpeed = 8.0f;

    public GameObject projectilePrefab;
    private float rotationSpeed = 200.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * moveSpeed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * moveSpeed);
        rotationalInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * rotationalInput * Time.deltaTime * rotationSpeed);

        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
