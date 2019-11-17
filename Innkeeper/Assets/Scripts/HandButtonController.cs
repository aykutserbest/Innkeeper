using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandButtonController : MonoBehaviour
{
    public GameSourceController source;



    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("Scripts").GetComponent<GameSourceController>();


    }

    private void Update()
    {
        source = GameObject.FindGameObjectWithTag("Scripts").GetComponent<GameSourceController>();
    }

    public void ButtonTest()
    {

        
        if (source.farmAreaStatus == 1  && source.seedStatus == 1)
        {
          
            GameObject.Find(source.farmAreaName).GetComponent<FarmPlantArea>().Plant();

        }
    }

}
