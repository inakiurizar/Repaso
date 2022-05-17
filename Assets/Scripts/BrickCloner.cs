using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour {

    public GameObject brickPrefab;
    // public Text txtUserCloneBricks;
    // int cloneAmount;
    int counter = 0;
    float xOffset;

    public void CloneBrick()
    {

        //if(txtUserCloneBricks.text != " ")
        //{
        //    cloneAmount = int.Parse(txtUserCloneBricks.text);
        //}

        if (counter < 5)
        {
            GameObject clon;
            clon = Instantiate(brickPrefab);
            // Destroy(clon, 2);
            clon.transform.position = new Vector3(xOffset, 0, 0);
            xOffset += 1.1f;
            counter++; 
        }
            
        }
    }
