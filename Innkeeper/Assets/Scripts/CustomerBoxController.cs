using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBoxController : MonoBehaviour
{

    public GameSourceController source;


    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("Scripts").GetComponent<GameSourceController>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {

            
            if (source.customerCount>0 && source.foodCount>=10 && source.drinkCount>=6)
            {
                source.customerCount--;
                source.foodCount = source.foodCount - 10;
                source.drinkCount = source.drinkCount - 6;
                source.goldCount = source.goldCount + source.increaseGold;

               
            }
            else
            {
                if (source.customerCount <= 0)
                {
                    Debug.Log("customer not enough");
                }
                if (source.foodCount < 10)
                {
                    Debug.Log("food not enough");
                }
                if (source.drinkCount < 6)
                {
                    Debug.Log("drink not enough");
                }
            }
            
        }
    }



}
