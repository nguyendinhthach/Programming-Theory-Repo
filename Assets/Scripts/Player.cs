using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 3;
    [SerializeField] private float rotateSpeed = 5;

    private void Awake()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    // Player's movement
    void HandleMovement()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * vertical * speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 1, 0) * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -1, 0) * rotateSpeed * Time.deltaTime);
        }
    }
}
