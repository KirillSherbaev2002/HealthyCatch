using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spewner : MonoBehaviour
{
    public GameObject tree;
    public GameObject camp;

    public float Prob = 2;

    public bool TentWasntSpawned = true;

    void FixedUpdate()
    {
        if (Random.Range(1,70) <= Prob && TentWasntSpawned)
        {
            Instantiate(tree, new Vector3 (Random.Range(-10, 10), transform.position.y, transform.position.z), Quaternion.identity);
            Prob = Prob + 0.01f;
        }
    }

    public void SpawnCamp()
    {
        if (TentWasntSpawned)
        {
            Instantiate(camp, new Vector3(Random.Range(-10, 10), transform.position.y, transform.position.z), Quaternion.identity);
            TentWasntSpawned = false;
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
