﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousecursor : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
       // Vector2 cursorpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // transform.position = cursorpos;
    }
}
