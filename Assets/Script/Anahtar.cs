using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anahtar : MonoBehaviour
{
    float rotationSpeed=250f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime , 0 );
    }
}
