using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToHud : MonoBehaviour
{
    bool go;
    public Transform hud;
    public AudioSource apple;

    // Update is called once per frame
    void Update()
    {
        if (go)
        {
            
            transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(hud.position), 20 * Time.deltaTime);
            Destroy(gameObject, 2f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            apple.Play();
            go = true;
        }
    }
}
