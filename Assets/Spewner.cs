using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spewner : MonoBehaviour
{
    public GameObject tree;

    public float Prob = 2;

    void Update()
    {
        if (Random.Range(1,100) <= Prob)
        {
            Instantiate(tree, new Vector3 (Random.Range(-10, 10), transform.position.y, transform.position.z), Quaternion.identity);
            Prob = Prob + 0.01f;
        }
    }
}
