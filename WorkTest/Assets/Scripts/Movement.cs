using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Movement : MonoBehaviour
{
    

    private Vector3 moveDirection;
    [SerializeField] private float speed = 500f;

    private CharacterController controller;
    public CharacterController Controller => controller ??= GetComponent<CharacterController>();
  

    private void Update()
    {
        moveDirection = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
