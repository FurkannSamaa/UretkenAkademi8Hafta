using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SayfaGecis : MonoBehaviour
{
    public void Sahne1()
    {
        SceneManager.LoadScene(1);
        
    }
    public void Sahne2()
    {
        SceneManager.LoadScene(2);

    }
    public void Sahne3()
    {
        SceneManager.LoadScene(3);

    }
    public void AnaMenü()
    {
        
        SceneManager.LoadScene(0);
        
    }
    public void Exit()
    {
        Application.Quit();
    }
}
