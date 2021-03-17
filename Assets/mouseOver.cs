using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOver : MonoBehaviour

{
    public GameObject target;
    void OnMouseDown()
    {
        Debug.Log("detection");
        // Destroy the gameObject after clicking on it
        Destroy(target); 
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
