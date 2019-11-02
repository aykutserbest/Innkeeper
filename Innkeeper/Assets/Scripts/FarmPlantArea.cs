using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmPlantArea : MonoBehaviour
{
    public GameObject seed;
    public GameObject plants;
    public GameSourceController source;
    public bool planted=false;
    public string plantedSeed;
   

    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("Scripts").GetComponent<GameSourceController>();
    }



    public void Plant()
    {

        if (planted)
        {
            print("ekili");
        }

        else
        {
           
             SeedVisible(source.seedType);
             PlantVisible(source.seedType);
        }
         

    }

    public void SeedVisible(string seedType)
    {
        planted = true;
        source.seedStatus = 0;
        if (source.seedType == "Wheat")
        {
            seed = GameObject.FindGameObjectWithTag("SeedWheat");
            seed.GetComponent<Renderer>().enabled = false;
        }
        else if (source.seedType == "GreenGrape")
        {
            seed = GameObject.FindGameObjectWithTag("SeedGreenGrape");
            seed.GetComponent<Renderer>().enabled = false;
        }
        else if (source.seedType == "RedGrape")
        {
            seed = GameObject.FindGameObjectWithTag("SeedRedGrape");
            seed.GetComponent<Renderer>().enabled = false;
        }
    }


    public void PlantVisible(string seedType)
    {

        if (source.seedType == "Wheat")
        {
            plants = GameObject.Find("WheatLevel1");
            plants.GetComponent<Renderer>().enabled = true;
        }
        else if (source.seedType == "GreenGrape")
        {
            plants = GameObject.Find("GreenGrapeLevel1");
            plants.GetComponent<Renderer>().enabled = true;
        }
        else if (source.seedType == "RedGrape")
        {
            plants = GameObject.Find("RedGrapeLevel1");
            plants.GetComponent<Renderer>().enabled = true;
        }

    }
    
}
