using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardOne : MonoBehaviour
{
    public float x, y, z;
    public GameObject CardBack;
    public bool cardBackisActive;
    public int timer;
    

    // Start is called before the first frame update
    void Start()
    {
        cardBackisActive = false;
    }

    // Update is called once per frame


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
           
            Startflip();
        }
    }

   public void Startflip ()

    {
        StartCoroutine(CalculatedFlip());

    }

    public void Flip()

    {
        if (cardBackisActive == true)
        {
            CardBack.SetActive(false); // false
            cardBackisActive = false; // false
        }


        else
        {
            CardBack.SetActive(true);// true
            cardBackisActive = true; // true
        }

    }

     IEnumerator CalculatedFlip()

    {
        for (int i =0; i < 180; i++)
        {
            yield return new WaitForSeconds(0.06f);
            transform.Rotate(new Vector3(x, y, z));
            timer++;

            if(timer == 90 || timer == - 90)
            {
                Flip();
            }

        }

        timer = 0;

    }


   }
