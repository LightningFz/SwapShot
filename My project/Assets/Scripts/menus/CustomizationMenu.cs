using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class CustomizationMenu : MonoBehaviour
{
    public Color[] petSkins;
    public GameObject[] buttons;

    public GameObject pet;
    private SpriteRenderer petImage;

    // Start is called before the first frame update
    void Start()
    {
        petImage = pet.GetComponentInChildren<SpriteRenderer>();
        for (int i = 0; buttons.Length > i ;i++)
        {
            UnityEngine.UI.Image button = buttons[i].GetComponentInChildren<UnityEngine.UI.Image>();
            button.color = petSkins[i];
        }
    }
    public void changePetColor(UnityEngine.UI.Image buttonColor)
    {
        petImage.color = buttonColor.color;
    }
}
