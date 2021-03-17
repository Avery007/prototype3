using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOver : MonoBehaviour

{
    public GameObject target;
    public GameObject wall;
    public UnityEngine.UI.Text text;
    private static int number = 0; 
    void OnMouseDown()
    {
        Debug.Log("detection");
        // Destroy the gameObject after clicking on it
        Destroy(target);
        number = number + 1;
        text.text = "balls collected: " + number;
        Debug.Log(number);
        if(number==4)
        {
            Destroy(wall);
            text.text = "Good job you got all of them! Now move to exit";
        }
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
