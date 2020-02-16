using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreafterdeath : MonoBehaviour
{

    Text finalscore;

    // Start is called before the first frame update
    void Start()
    {
        finalscore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       
        finalscore.text = "Score : " + scorescript.scorevalue.ToString();
    }
}
