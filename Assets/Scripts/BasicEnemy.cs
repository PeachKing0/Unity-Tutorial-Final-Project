using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public float speed = 2;
    public float maxValue = 6.47f; // or whatever you want the max value to be
    public float minValue = 2.82f; // or whatever you want the min value to be
    public float currentValue = 6.47f; // or wherever you want to start
    public int direction = 1;


    public virtual void INUpdate()
    {
        currentValue += Time.deltaTime * direction * speed; // or however you are incrementing the position
        if (currentValue >= maxValue)
        {
            direction *= -1;
            currentValue = maxValue;
        }
        else if (currentValue <= minValue)
        {
            direction *= -1;
            currentValue = minValue;
        }
        transform.position = new Vector3(currentValue, 3.01f, 0);
    }
}