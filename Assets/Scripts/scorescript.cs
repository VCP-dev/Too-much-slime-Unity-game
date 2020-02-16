using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{

    Text score;
    public static long scorevalue;

    // Start is called before the first frame update
    void Start()
    {
        scorevalue = 0;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scorevalue.ToString();
    }
}
