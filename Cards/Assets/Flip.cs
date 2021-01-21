using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Flip : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{

    public GameObject CardBack;
    public bool cardBackisActive;
    public bool MouseOnObject = false;



    // Start is called before the first frame update
    void Start()
        
    {


    }

    // Update is called once per frame


    void Update()
    {

        if (Input.GetMouseButtonDown(0) && (!MouseOnObject))

        {
            OnMouseDown();
            

        }

    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        MouseOnObject = false;

    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        MouseOnObject = true;
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



