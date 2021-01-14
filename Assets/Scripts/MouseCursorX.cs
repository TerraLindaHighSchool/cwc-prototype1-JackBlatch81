using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorX : MonoBehaviour
{
    public GameObject clickEffect;
    public Sprite cursor;
    private SpriteRenderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
        
        if (Input.GetMouseButtonDown(0))
        {
            rend.sprite = cursor;
            Instantiate(clickEffect, transform.position, Quaternion.identity);
        }
    }
}
