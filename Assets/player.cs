using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{ 
    public SwitchScene ChangeScene;
    public Spewner Spewner;

    public float MaxX;
    public float speed;

    public float RangeToGroup = 100;
    public TMP_Text Range;

    public GameObject flare;
    public GameObject congrats;

    void FixedUpdate()
    {
        #region Control
        if (Spewner.TentWasntSpawned) 
        {
            Vector3 newPadposition = new Vector3();
            Vector3 mousePixelPoint = Input.mousePosition;
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePixelPoint);

            newPadposition = new Vector3(mouseWorldPosition.x, transform.position.y, 0);
            newPadposition.x = Mathf.Clamp(newPadposition.x, -MaxX, MaxX);
            transform.position = newPadposition;

            RangeToGroup -= speed * 0.05f * Time.deltaTime;
            Range.text = Mathf.Floor(RangeToGroup).ToString();
        }
        #endregion 
        if (Spewner.TentWasntSpawned)
        {
            RangeToGroup -= speed * 0.07f * Time.deltaTime;
            Range.text = RangeToGroup.ToString("F0")+"M";
            if (RangeToGroup <= 0)
            {
                Spewner.SpawnCamp();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tree"))
        {
            ChangeScene.SwitchToStart();
        }
    }

    public void Flare()
    {
        Instantiate(flare, new Vector3(transform.position.x, transform.position.y+2, transform.position.z-4), Quaternion.identity);
        Instantiate(congrats);
    }
}
