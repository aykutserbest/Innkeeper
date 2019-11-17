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
    public int plantLevel;
    private PlayerMovement playerMovement;

    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("Scripts").GetComponent<GameSourceController>();
        playerMovement = FindObjectOfType<PlayerMovement>();
    }


    public void Plant()
    {

        if (planted)
        {
            print("ekili");
        }

        else
        {
             plantLevel = 1;
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
            plantedSeed = "Wheat";
            
        }
        else if (source.seedType == "GreenGrape")
        {
            seed = GameObject.FindGameObjectWithTag("SeedGreenGrape");
            seed.GetComponent<Renderer>().enabled = false;
            plantedSeed = "SeedGreenGrape";
        }
        else if (source.seedType == "RedGrape")
        {
            seed = GameObject.FindGameObjectWithTag("SeedRedGrape");
            seed.GetComponent<Renderer>().enabled = false;
            plantedSeed = "SeedRedGrape";
        }
    }


    public void PlantVisible(string seedType)
    {
        
        for (int i = 0; i < playerMovement.foundFarm.transform.childCount; i++)
        {
            
            if (playerMovement.foundFarm.transform.GetChild(i).name == "WheatLevel"+ plantLevel + "" && source.seedType == "Wheat")
            {     
                    playerMovement.foundFarm.transform.GetChild(i).GetComponent<Renderer>().enabled = true;   
                    
            }

            else if (playerMovement.foundFarm.transform.GetChild(i).name == "RedGrapeLevel"+ plantLevel + "" && source.seedType == "RedGrape")
            {
                playerMovement.foundFarm.transform.GetChild(i).GetComponent<Renderer>().enabled = true;
            }

            else if (playerMovement.foundFarm.transform.GetChild(i).name == "GreenGrapeLevel" + plantLevel + "" && source.seedType == "GreenGrape")
            {
                playerMovement.foundFarm.transform.GetChild(i).GetComponent<Renderer>().enabled = true;
            }

        }




        //if (source.seedType == "Wheat")
        //{        
        //    plants = GameObject.Find("WheatLevel1");
        //    plants.GetComponent<Renderer>().enabled = true;
        //}
        //else if (source.seedType == "GreenGrape")
        //{
        //    plants = GameObject.Find("GreenGrapeLevel1");
        //    plants.GetComponent<Renderer>().enabled = true;
        //}
        //else if (source.seedType == "RedGrape")
        //{
        //    plants = GameObject.Find("RedGrapeLevel1");
        //    plants.GetComponent<Renderer>().enabled = true;
        //}

    }
    
}
