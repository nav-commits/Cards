using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Flip : MonoBehaviour
{

    public GameObject CardBack;
    public bool cardBackisActive;
   
   
    // Start is called before the first frame update
    void Start()
        
    {
       
    }


    // Update is called once per frame


    void Update()
    {

        if (Input.GetMouseButtonDown(0))

        {
            OnMouseDown();
        }


    }




    private void OnMouseDown()

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