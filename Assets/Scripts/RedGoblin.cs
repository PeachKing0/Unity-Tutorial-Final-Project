using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGoblin : BasicEnemy
{
    void Start()
    {
        speed = 3;
        maxValue = 2.85f;
        minValue = 0.15f;
        currentValue = 2.44f;
    }

    void Update()
    {
        INUpdate();
    }

    public override void INUpdate()
    {
        base.INUpdate();
        // The rest of the base method is already added. Any lines below simply overwrite the original line(s) you want to overwrite
        transform.position = new Vector3(-8.28f, currentValue, 0);
    }
}
