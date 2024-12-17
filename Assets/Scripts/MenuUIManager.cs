using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    [SerializeField] GameObject highScoresGUI;
    [SerializeField] GameObject menuGUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToHighscores()
    {
        menuGUI.SetActive(false);
        highScoresGUI.SetActive(true);
    }

    public void GoToMenu()
    {
        highScoresGUI.SetActive(false);
        menuGUI.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }
}
