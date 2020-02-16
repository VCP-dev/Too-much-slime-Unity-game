using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changecolourpanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Image img = GameObject.Find("Game-over-panel").GetComponent<Image>();
        img.color = UnityEngine.Color.black;
    }

    
}
