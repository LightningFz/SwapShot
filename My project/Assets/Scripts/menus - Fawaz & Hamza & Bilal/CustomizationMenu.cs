using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEditor.UI;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Linq;

public class CustomizationMenu : MonoBehaviour
{
    public Color[] petSkins;
    public GameObject[] buttons;
    public int[] sceneBuildIndexList;
    public UnityEngine.SceneManagement.Scene[] scene;
    public GameObject[] pet;

    private GameObject lvl;
    private SpriteRenderer petImage;
    //public List<GameObject> root;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; sceneBuildIndexList.Length > i; i++)
        {
            Debug.Log(scene[i]);
            scene[i] = SceneManager.GetSceneByBuildIndex(sceneBuildIndexList[i]);
            //scene[i].GetRootGameObjects();
            Debug.Log(SceneManager.GetSceneByBuildIndex(1));
            Debug.Log(i);
            Debug.Log(lvl);
        }
        //petImage = pet[].GetComponentInChildren<SpriteRenderer>();
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
