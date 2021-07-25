using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    private float horizontalinput;
    private float verticalinput;

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");
        // Move player on vertical axis based on user input
        transform.Translate(Vector2.up * verticalinput * speed * Time.deltaTime);
        // Move player on horizontal axis based on user input
        transform.Translate(Vector2.right * speed * horizontalinput * Time.deltaTime);
    }
}
