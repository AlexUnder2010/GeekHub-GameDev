using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checker : MonoBehaviour
{
    // Use this for initialization
    int i = 0;
    private Time time;
    public Text Score;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerExit(Collider col)
    {
        
        if (col.gameObject.tag == "Pin")
        {
            i++;
            Score.text = i.ToString();
            if (i >= 10)
                Score.text = "Strike";
        }
    }
}
