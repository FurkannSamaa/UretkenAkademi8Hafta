using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject panel;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject key;
    public GameObject keyHint;
    public Animator animator;

    bool isAnahtar;
    int y�ld�zSayisi;
    public int oyunBittiMi=0;

    Code code = new Code();
    
    // Start is called before the first frame update
    void Start()
    {
        y�ld�zSayisi = 0;
        isAnahtar = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {  
        if(collision.gameObject.tag == "Flag")
        {
            panel.SetActive(true);
            oyunBittiMi = 1;
            if(y�ld�zSayisi == 1)
                image1.SetActive(true);
            if(y�ld�zSayisi == 2)
            {
                image1.SetActive(true);
                image2.SetActive(true);
            }
            if (y�ld�zSayisi == 3)
            {
                image1.SetActive(true);
                image2.SetActive(true);
                image3.SetActive(true);
            }
            Time.timeScale = 0f;
        }
        if(collision.gameObject.tag == "Door" )
        {
            
            key.SetActive(true);
            if (isAnahtar)
            {
                animator.SetBool("isOpen", true);
            }
            else
            {
                keyHint.SetActive(true);
            }

        }
        


    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Door" && !isAnahtar)
        {
            keyHint.SetActive(false);
        }

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Star")
        {
            Destroy(other.gameObject);
            y�ld�zSayisi++;
        }
        if(other.gameObject.tag == "Key")
        {
            key.SetActive(false);
            isAnahtar = true;
        }
    }


}
