using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    
    public GameObject CardBack;
    public bool cardBackisActive;
    public GameObject CardOne;

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            flip();


        }
    }


    public void flip()


    {

        if (cardBackisActive)
        {
            CardBack.SetActive(true);
           

        }

        else
        {
            
            CardOne.SetActive(true);
            CardBack.SetActive(false);

           
        }

    }
}
