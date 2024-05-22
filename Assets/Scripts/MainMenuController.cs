using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    void Start()
    {
        button1.onClick.AddListener(OnButtonOne);
        button2.onClick.AddListener(OnButtonTwo);
        button3.onClick.AddListener(OnButtonThree);
    }

    void OnButtonOne()
    {
        SceneManager.LoadScene("FirstScene");
    }

    void OnButtonTwo()
    {
        SceneManager.LoadScene("SecondScene");
    }

    void OnButtonThree()
    {
        SceneManager.LoadScene("ThirdScene");
    }
}
