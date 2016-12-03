using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunburstClick : MonoBehaviour
{
    public GameObject button;
    public GameObject stars1;
    public GameObject stars2;
    public GameObject stars3;
    public GameObject stars4;
    public GameObject sunburst;

    // Use this for initialization
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (stars1.activeSelf != true)
        {
            stars1.SetActive(true);
            stars2.SetActive(true);
            stars3.SetActive(true);
            stars4.SetActive(true);
            sunburst.SetActive(true);
        }
        else
        {
            stars1.SetActive(false);
            stars2.SetActive(false);
            stars3.SetActive(false);
            stars4.SetActive(false);
            sunburst.SetActive(false);
        }
    }
}
