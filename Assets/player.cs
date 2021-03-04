using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{ 
    public SwitchScene ChangeScene;
    public float MaxX;
    public float speed;

    public float RangeToGroup = 1000;
    public TMP_Text Range;

    public bool DidYouWon;
    void Update()
    {
        Vector3 newPadposition = new Vector3(); 
        Vector3 mousePixelPoint = Input.mousePosition;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePixelPoint);

        newPadposition = new Vector3(mouseWorldPosition.x, transform.position.y, 0);
        newPadposition.x = Mathf.Clamp(newPadposition.x, -MaxX, MaxX);
        transform.position = newPadposition;

        RangeToGroup -= speed * 0.1f * Time.deltaTime;
        Range.text = RangeToGroup.ToString();
        if (DidYouWon)
        {
            Range.text = "You Saved Them!".ToString();
        }
        else
        {
            RangeToGroup -= speed * 0.1f * Time.deltaTime;
            Range.text = RangeToGroup.ToString();
            if (RangeToGroup <= 0)
            {
                DidYouWon = true;
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
}
