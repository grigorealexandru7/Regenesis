using System;
using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -9.81f;
    public float jump = 20f;
    public float Sensivity = 1f;

    private CharacterController controller;
    private Vector3 movement;
    private float rotationY;
    private float verticalVelocity;
    
    public Mission mission;
    public GameObject UnderWater;
    public GameObject UnderwaterGOOD;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        if(mission.color==0) 
            UnderWater.SetActive(false);
        else
            UnderwaterGOOD.SetActive(false);
    }

    void Update()
    {
        rotate();
        Move();
    }
    private bool inwater=false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            inwater = true;
            if(mission.color==0) 
                UnderWater.SetActive(true);
            else
                UnderwaterGOOD.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            inwater = false;
            if(mission.color==0) 
                UnderWater.SetActive(false);
            else
                UnderwaterGOOD.SetActive(false);
        }
    }
    

    private void Move()
    {
        float x = 0;
        float y = 0;

        if (Keyboard.current.aKey.isPressed)
        {
            x = -1;            
        }


        if (Keyboard.current.dKey.isPressed)
        {
            x = 1;            
        }


        if (Keyboard.current.sKey.isPressed)
        {
            y = -1;
        }


        if (Keyboard.current.wKey.isPressed)
        {
            y = 1;            
        }
        
        movement = new Vector3(x, 0f, y);

        movement = transform.TransformDirection(movement);
        movement = movement.normalized;

        if (controller.isGrounded && verticalVelocity < 0) 
        {
            verticalVelocity = -2f;
        }


        if (Keyboard.current.spaceKey.wasPressedThisFrame && inwater == true )
        {
            verticalVelocity = Mathf.Sqrt(jump * -2f * gravity);
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 velocity = movement * speed;
        velocity.y = verticalVelocity;

        controller.Move(velocity * Time.deltaTime);
    }

    private void rotate()
    {
        float mouseX = Mouse.current.delta.x.ReadValue() * Sensivity;

        rotationY += mouseX;

        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
    }
}