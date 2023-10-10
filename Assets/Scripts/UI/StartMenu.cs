using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] GameObject MainMenuUI;
    [SerializeField] GameObject InstructionUI;
    [SerializeField] public string StartLevel;

    public void seeDetial()
    {
        MainMenuUI.SetActive(false);
        InstructionUI.SetActive(true);
    }

    public void ReturnMain()
    {
        InstructionUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(StartLevel);
    }

}
