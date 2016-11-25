using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject Content;
    public GameObject Scrollview;

    public float ButtonDistance = 4.5f;
    public float RealDistance = 0;
    public Transform image1;
    public Transform image2;
    public Transform image3;
    public Transform image4;

    public GameObject Bottom_Left_Text;
    public GameObject Button;

    private float dist1;
    private float dist2;
    private float dist3;
    private float dist4;

    void Update()
    {
        dist1 = Vector3.Distance(image1.position, transform.position);
        dist2 = Vector3.Distance(image2.position, transform.position);
        dist3 = Vector3.Distance(image3.position, transform.position);
        dist4 = Vector3.Distance(image4.position, transform.position);


        if (Button.activeSelf == false)
            Scrollview.SetActive(false);

        Scrollview_Check();
        Painting_Name();
        Button_Trigger();
    }

    void Painting_Name()
    {
        if (dist1 < dist2 && dist1 < dist3 && dist1 < dist4)
        {
            Bottom_Left_Text.GetComponent<Text>().text = "Leonardo Da Vinci - Mona Lisa";
            RealDistance = dist1;
        }


        else if (dist2 < dist1 && dist2 < dist3 && dist2 < dist4)
        {
            Bottom_Left_Text.GetComponent<Text>().text = "Unknown - Ship";
            RealDistance = dist2;
        }
        else if (dist3 < dist1 && dist3 < dist2 && dist3 < dist4)
        {
            Bottom_Left_Text.GetComponent<Text>().text = "Victor Vasnetsov - Three Heroes";
            RealDistance = dist3;
        }
        else if (dist4 < dist1 && dist4 < dist3 && dist4 < dist2)
        {
            Bottom_Left_Text.GetComponent<Text>().text = "Edvard Munch - Skrik";
            RealDistance = dist4;
        }
        else
            Bottom_Left_Text.GetComponent<Text>().text = "Unreachable";

    }
    void Button_Trigger()
    {
        if ((dist1 < ButtonDistance) || (dist2 < ButtonDistance) || (dist3 < ButtonDistance) || (dist4 < ButtonDistance))
            Button.SetActive(true);
        else
            Button.SetActive(false);
    }

    void Scrollview_Check()
    {
        if (Bottom_Left_Text.GetComponent<Text>().text == "Leonardo Da Vinci - Mona Lisa" && Button.activeSelf)
        {
            Content.GetComponent<Text>().text = "The painting, thought to be a portrait of Lisa Gherardini, the wife of Francesco del Giocondo, is in oil on a white Lombardy poplar panel, and is believed to have been painted between 1503 and 1506. Leonardo may have continued working on it as late as 1517. It was acquired by King Francis I of France and is now the property of the French Republic, on permanent display at the Louvre Museum in Paris since 1797.";
        }
        else if (Bottom_Left_Text.GetComponent<Text>().text == "Unknown - Ship" && Button.activeSelf)
        {
            Content.GetComponent<Text>().text = "Just a picture from Google";
        }
        else if (Bottom_Left_Text.GetComponent<Text>().text == "Victor Vasnetsov - Three Heroes" && Button.activeSelf)
        {
            Content.GetComponent<Text>().text = "Three of the most famous bogatyrs, Dobrynya Nikitich, Ilya Muromets and Alyosha Popovich, are represented together in Victor Vasnetsov's 1898 painting Bogatyrs.";
        }
        else if (Bottom_Left_Text.GetComponent<Text>().text == "Edvard Munch - Skrik" && Button.activeSelf)
        {
            Content.GetComponent<Text>().text = "The Scream (Norwegian: Skrik) is the popular name given to each of four versions of a composition, created as both paintings and pastels, by the Expressionist artist Edvard Munch between 1893 and 1910. The German title Munch gave these works is Der Schrei der Natur (The Scream of Nature). The works show a figure with an agonized expression against a landscape with a tumultuous orange sky. Arthur Lubow has described The Scream as an icon of modern art, a Mona Lisa for our time.";
        }
    }
}
