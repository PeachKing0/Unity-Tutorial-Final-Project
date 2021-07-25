using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGoblin : BasicEnemy
{
    public void Update()
    {
        INUpdate();
    }
    /*public override void Movement()
    {
        base.Movement();
        StartCoroutine(MoveTime(WaitTime));
        if (thingie == true)
        {
            while (thingie == true)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                Debug.Log("cheam");
                return;
            }
        }
        if (thingie == false)
        {
            while (thingie == false)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                Debug.Log("cheam");
                return;
            }
        }
    }

    IEnumerator MoveTime(float WaitTime)
    {
        yield return new WaitForSeconds(WaitTime);
        if (thingie == false)
        {
            thingie = true;
        }
        else if (thingie == true)
        {
            thingie = false;
        }
        Movement();
    }*/
}
