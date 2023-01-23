using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playerName : MonoBehaviour
{
    // vairables
    public string nameOfPlayer;
    public string saveName;
    public TextMeshProUGUI inputText;
    public TextMeshProUGUI loadedName;

    // Update is called once per frame
    void Update()
    {
        nameOfPlayer = PlayerPrefs.GetString("name" , "none");
        loadedName.text = nameOfPlayer;
    }

    public void Setname()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }
}
