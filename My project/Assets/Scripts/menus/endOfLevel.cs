using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endOfLevel : MonoBehaviour
{
    public GameObject endOflevelMenu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            endOflevelMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
