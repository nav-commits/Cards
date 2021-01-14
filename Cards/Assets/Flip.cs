using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    
    public GameObject CardBack;
    public bool cardBackisActive;
 

    // Start is called before the first frame update
    void Start()
    {
        //cardBackisActive = false;

    }

    // Update is called once per frame


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            OnMouseDown();

        }
        
    }


  

     public void OnMouseDown()

    {  

        cardBackisActive = !cardBackisActive;

        if (cardBackisActive)
        {
            CardBack.SetActive(true);
            

        }

        else
        {
            
            CardBack.SetActive(false);


        }

    }

    

}
