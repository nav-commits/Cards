using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
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


    public void Startflip()

    {
        StartCoroutine(CalculatedFlip());

    }

    public void flip()

    {

        if (cardBackisActive == true)
        {
            CardBack.SetActive(false); 
            cardBackisActive = false; 
           
        }


        else
        {
            CardBack.SetActive(true);
            cardBackisActive = true; 
        }




    }

    IEnumerator CalculatedFlip()

    {
        for (int i = 0; i < 180; i++)
        {
            yield return new WaitForSeconds(0.02f);
            transform.Rotate(new Vector3(x, y)); //x y z
            timer++;

            if (timer == 60 || timer == -60)
            {
                flip();
            }

        }

        timer = 0;

    }
}
