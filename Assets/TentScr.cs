using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentScr : MonoBehaviour
{
    public GameObject Fire;
    public Rigidbody2D rb;
    public Collider2D coll;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(Fire);
            Time.timeScale = 0;
            Destroy(rb);
            coll.enabled = false;
        }
    }
    public void Update()
    {
        if (rb)
        {
            rb.rotation = 0;
        }
    }
}
