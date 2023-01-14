using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelSelector : MonoBehaviour
{
    public int level;
    public TextMeshProUGUI levelText;
    // Start is called before the first frame update
    void Start()
    {
        levelText.text = level.ToString();
    }

    public void openScene()
    {
        SceneManager.LoadScene("level " + level.ToString());
    }
}
