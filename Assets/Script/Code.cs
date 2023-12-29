using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Code : MonoBehaviour
{
    public GameObject Masa;
    public GameObject panel;
    public GameObject Pause;
    public Text zaman;
    float süre;
    public float rotationSpeed=0.1f;
    float rotationX = 0.0f;
    float rotationZ = 0.0f;
    bool aktif = true;
    

    

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        süre += Time.deltaTime;
        zaman.text = "Süre: "+(int)süre;

        if (Input.GetKey(KeyCode.W) && rotationX <= 15)
        {
            rotationX += rotationSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && rotationX >= -15)
        {
            rotationX -= rotationSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && rotationZ <= 15)
        {
            rotationZ += rotationSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && rotationZ >= -15)
        {
            rotationZ -= rotationSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && !panel.activeSelf)
        {
            if (aktif)
            {
                Pause.SetActive(true);
                Time.timeScale = 0;
                aktif = false;
            }
            else
            {
                Pause.SetActive(false);
                Time.timeScale = 1;
                aktif = true;
            }
        }
            

        
        

        Masa.transform.rotation = Quaternion.Euler(rotationX, 0, rotationZ);

    }

   

    

}
