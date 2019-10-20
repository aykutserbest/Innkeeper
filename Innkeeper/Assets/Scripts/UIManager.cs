using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public GameSourceController source;
    public Text goldText;
    public Text foodText;
    public Text drinkText;
    public Text customerCountText;
    

    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("Scripts").GetComponent<GameSourceController>();

       
    }

    private void Update()
    {
        goldText.text = "Gold : "+source.goldCount.ToString();
        foodText.text = "Food : " + source.foodCount.ToString();
        drinkText.text = "Drink : " + source.drinkCount.ToString();
       customerCountText.text= source.customerCount.ToString();
    }

}

    
