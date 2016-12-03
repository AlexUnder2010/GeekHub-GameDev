using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoButton : MonoBehaviour
{

    public Button button;

    public GameObject MercuryText;
    public GameObject MercuryText1;
    public GameObject MercuryText2;

    public GameObject VenusText;
    public GameObject VenusText1;
    public GameObject VenusText2;

    public GameObject EarthText;
    public GameObject EarthText1;
    public GameObject EarthText2;

    public GameObject MarsText;
    public GameObject MarsText1;
    public GameObject MarsText2;

    public GameObject JupiterText;
    public GameObject JupiterText1;
    public GameObject JupiterText2;

    public GameObject SaturnText;
    public GameObject SaturnText1;
    public GameObject SaturnText2;

    public GameObject UranusText;
    public GameObject UranusText1;
    public GameObject UranusText2;

    public GameObject NeptuneText;
    public GameObject NeptuneText1;
    public GameObject NeptuneText2;

    public GameObject Info1;
    public GameObject Info2;

    // Use this for initialization
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (Info1.activeSelf)
        {
            EarthText.SetActive(false);
            EarthText1.SetActive(false);
            EarthText2.SetActive(false);

            MercuryText.SetActive(false);
            MercuryText1.SetActive(false);
            MercuryText2.SetActive(false);

            VenusText.SetActive(false);
            VenusText1.SetActive(false);
            VenusText2.SetActive(false);

            NeptuneText.SetActive(false);
            NeptuneText1.SetActive(false);
            NeptuneText2.SetActive(false);

            JupiterText.SetActive(false);
            JupiterText1.SetActive(false);
            JupiterText2.SetActive(false);

            UranusText.SetActive(false);
            UranusText1.SetActive(false);
            UranusText2.SetActive(false);

            MarsText.SetActive(false);
            MarsText1.SetActive(false);
            MarsText2.SetActive(false);

            SaturnText.SetActive(false);
            SaturnText1.SetActive(false);
            SaturnText2.SetActive(false);

            Info1.SetActive(false);
            Info2.SetActive(false);
        }
        else
        {
            EarthText.SetActive(true);
            EarthText1.SetActive(true);
            EarthText2.SetActive(true);

            MercuryText.SetActive(true);
            MercuryText1.SetActive(true);
            MercuryText2.SetActive(true);

            VenusText.SetActive(true);
            VenusText1.SetActive(true);
            VenusText2.SetActive(true);

            NeptuneText.SetActive(true);
            NeptuneText1.SetActive(true);
            NeptuneText2.SetActive(true);

            JupiterText.SetActive(true);
            JupiterText1.SetActive(true);
            JupiterText2.SetActive(true);

            UranusText.SetActive(true);
            UranusText1.SetActive(true);
            UranusText2.SetActive(true);

            MarsText.SetActive(true);
            MarsText1.SetActive(true);
            MarsText2.SetActive(true);

            SaturnText.SetActive(true);
            SaturnText1.SetActive(true);
            SaturnText2.SetActive(true);

            Info1.SetActive(true);
            Info2.SetActive(true);
        }
    }
}