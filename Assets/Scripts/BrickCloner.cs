using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour {

    public GameObject brickPrefab;
    public Text txtOffset;
    // int cloneAmount;
    int counter = 0;
    float xOffset;


    void start()
    {
        
    }

    public void CloneBrick()
    {
        if(counter == 0)
        {
            xOffset = float.Parse(txtOffset.text);
        }
         
        if (counter < 5)
        {

            GameObject clon;
            clon = Instantiate(brickPrefab);
            // Destroy(clon, 2);
            clon.transform.position = new Vector3(float.Parse(txtOffset.text), 0, 0);
            counter++; 
        }
            
        }
    }
