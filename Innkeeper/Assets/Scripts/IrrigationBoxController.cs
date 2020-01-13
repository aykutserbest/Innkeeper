using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrrigationBoxController : MonoBehaviour
{
    public GameSourceController source;
    public GameObject plantAreaObject;
    public FarmPlantArea plantedArea;
    int level;

    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.FindGameObjectWithTag("Scripts").GetComponent<GameSourceController>();
        plantedArea = plantAreaObject.GetComponent<FarmPlantArea>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            if (plantedArea.plantedSeed == "")
            {
                
            }
            else
            {
                level = plantedArea.plantLevel;
                level++;
                plantedArea.plantLevel = level;
                plantedArea.PlantVisible(plantedArea.plantedSeed);
                Debug.Log(level);
            }
        }
    }
}
