using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public bool dirRight=true;
    public float movTime;
    public float speed;
    public float timer;

    // Update is called once per frame
    void Update()
    {
        if (dirRight)
        {
            transform.Translate(speed * Time.deltaTime * Vector2.right);
        }
        else
        {
            transform.Translate(speed * Time.deltaTime * Vector2.left);
        }

        timer += Time.deltaTime;

        if (timer >= movTime)
        {
            dirRight = !dirRight;
            timer = 0f;
        }
    }
}
