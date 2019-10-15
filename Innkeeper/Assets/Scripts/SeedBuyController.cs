using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedBuyController : MonoBehaviour
{
    public GameObject seed;

    private void Start()
    {
        seed = GameObject.FindGameObjectWithTag("Seed");

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {          
            if (gameObject.transform.tag == "SeedBuyApple")
            {
                Debug.Log("elma seedi aldınız");
                
                seed.GetComponent<Renderer>().enabled = true;

            }
        }
    }
}

//seed = GameObject.FindGameObjectWithTag("Seed");
//        seed.GetComponent<Renderer>().enabled = false;
//         public GameObject seed;