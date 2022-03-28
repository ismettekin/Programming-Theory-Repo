using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class MainUI : MonoBehaviour
{
    [SerializeField] GameObject endTitle;

    private void Update() 
    {
        if(GameManager.Instance.isGameActive == false)
        {
            endTitle.SetActive(true);
        }
    }
    public void GameOverButton()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
