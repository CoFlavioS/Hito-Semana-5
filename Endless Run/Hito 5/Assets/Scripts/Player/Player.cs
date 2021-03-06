﻿using UnityEngine;

[RequireComponent(typeof(Controller2D))]
public class Player : MonoBehaviour
{
    public float maxJumpHeight = 4f;
    public float minJumpHeight = 1f;
    public float timeToJumpApex = .4f;

    private float gravity = -50;
    private float maxJumpVelocity;
    private float minJumpVelocity;
    private Vector3 velocity;

    private Controller2D controller;
    public Animator animator;

    private void Start()
    {
        controller = GetComponent<Controller2D>();
        maxJumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
        minJumpVelocity = Mathf.Sqrt(2 * Mathf.Abs(gravity) * minJumpHeight);
    }

    private void Update()
    {
        animator.SetFloat("velocityY", velocity.y);

        Debug.LogError(velocity.y);

        CalculateVelocity();

        controller.Move(velocity * Time.deltaTime, Vector2.zero);

        if (controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0f;
        }
    }

    public void OnJumpInputDown()
    {
        if (controller.collisions.below)
        {
            velocity.y = maxJumpVelocity;
        }
    }

    public void OnJumpInputUp()
    {
        if (velocity.y > minJumpVelocity)
        {
            velocity.y = minJumpVelocity;
        }
    }

    private void CalculateVelocity()
    {
        velocity.y += gravity * Time.deltaTime;
    }

}
