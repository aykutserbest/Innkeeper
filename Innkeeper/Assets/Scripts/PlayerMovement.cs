using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public GameSourceController source;
    public GameObject foundFarm;

    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("Scripts").GetComponent<GameSourceController>();
    }



    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

       
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }



    //farm
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Farm")
        {

            source.farmAreaStatus = 1;
            source.farmAreaName = collision.gameObject.name.ToString();



            foundFarm = collision.gameObject;
            Debug.Log(foundFarm);


        


        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Farm")
        {

            source.farmAreaStatus = 0;
            source.farmAreaName = "";
           

        }
    }

}
