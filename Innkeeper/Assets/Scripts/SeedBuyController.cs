using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedBuyController : MonoBehaviour
{
   
    

    private GameSourceController source;

    private void Start()
    {
        
        source = GameObject.FindGameObjectWithTag("Scripts").GetComponent<GameSourceController>();  

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {          

            if (gameObject.transform.tag == "SeedBuyWheat" && source.seedStatus == 0)
            {
                Debug.Log("bugday seedi aldınız");
                GameObject.FindGameObjectWithTag("SeedWheat").GetComponent<Renderer>().enabled = true;
                source.seedStatus = 1;
                source.seedType = "SeedBuyWheat";
            }
            else if (gameObject.transform.tag == "SeedBuyGreenGrape" && source.seedStatus == 0)
            {
                Debug.Log("yeşil üzüm seedi aldınız");
                GameObject.FindGameObjectWithTag("SeedGreenGrape").GetComponent<Renderer>().enabled = true;
                source.seedStatus = 1;
                source.seedType = "SeedBuyGreenGrape";
            }
            else if (gameObject.transform.tag == "SeedBuyRedGrape" && source.seedStatus == 0)
            {
                Debug.Log("kırmızı üzüm seedi aldınız");
                GameObject.FindGameObjectWithTag("SeedRedGrape").GetComponent<Renderer>().enabled = true;
                source.seedStatus = 1;
                source.seedType = "SeedBuyRedGrape";
                
            }
            else if (gameObject.transform.tag == "BuyChicken" && source.seedStatus == 0)
            {
                Debug.Log("tavuk seedi aldınız");
                GameObject.FindGameObjectWithTag("SeedChicken").GetComponent<Renderer>().enabled = true;
                source.seedStatus = 1;
                source.seedType = "BuyChicken";

            }
            else if (gameObject.transform.tag == "BuySheep" && source.seedStatus == 0)
            {
                Debug.Log("tavuk seedi aldınız");
                GameObject.FindGameObjectWithTag("SeedSheep").GetComponent<Renderer>().enabled = true;
                source.seedStatus = 1;
                source.seedType = "BuySheep";

            }
            else if (gameObject.transform.tag == "BuyCow" && source.seedStatus == 0)
            {
                Debug.Log("tavuk seedi aldınız");
                GameObject.FindGameObjectWithTag("SeedCow").GetComponent<Renderer>().enabled = true;
                source.seedStatus = 1;
                source.seedType = "BuyCow";

            }









        }
    }

   
    
}

//seed = GameObject.FindGameObjectWithTag("Seed");
//        seed.GetComponent<Renderer>().enabled = false;
//         public GameObject seed;