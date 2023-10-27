using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private float movementX;

    void Awake()
    {
        Debug.Log("SEX");
    }

    private void Update()
    {
        HandlePlayerMovement();
    }

    void HandlePlayerMovement()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * (moveSpeed * Time.deltaTime);
    }
}
