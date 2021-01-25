using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement_EASY2 : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _jumpForce;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalMovement, 0, 0) * Time.deltaTime * _speed;

        if (!Mathf.Approximately(0, horizontalMovement))
        {
            transform.rotation = horizontalMovement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        var verticalMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, verticalMovement, 0) * Time.deltaTime * _speed;

    }

    
}
