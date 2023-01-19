using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class levels : MonoBehaviour
{
    [SerializeField]
    public GameObject[] level;

    private int levelNumber;
    private TextMeshProUGUI levelText;

    // Start is called before the first frame update
    void Start()
    {
        int x = 1;
        for (int i = 0; level.Length > i; i++)
        {
            levelText = level[i].GetComponentInChildren<TextMeshProUGUI>();
            levelText.text = x.ToString();
            x++;
        }
    }

    public void openScene(int number)
    {
        SceneManager.LoadScene("level " + number);
    }
}
