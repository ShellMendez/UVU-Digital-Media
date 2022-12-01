using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField] float xValue = 0.0f;
    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 100f;

   void Start()
    {
        //transform.Translate(0, 0,0);//Accessing transform of the object
        printInstruction();

    }

    // Update is called once per frame
    void Update()

    {
        movePlayer();
         
    }
    void printInstruction()
    {
        Debug.Log("WElcome to the GAME");
        Debug.Log("Avoid getting hit");
        Debug.Log("Don't hit the walls");
    }

    void movePlayer()
    {

        //float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        ////float yValue = Input.GetAxis("Vertical");
        //float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        //transform.Translate(Vector3.up);//Accessing transform of the object
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    this.transform.Translate(Vector3.forward * Time.deltaTime);
        //}
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.forward * (Time.deltaTime * 5));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * (Time.deltaTime *5));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * (Time.deltaTime*5));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.back * (Time.deltaTime*5));
        }

    }
}



//Cinemachine is used to cerate multiple camera for example if you would like to create a camera for the fight and another for you walking
/*
 * Method Real World Example
 * Methods execute blocks that makes our game do things
 * To achieve we must 
 *  Declare abnd define our method
 *  Call our method 
 *  
    //Declare method In this case
    Step1 Declare  = CleanYourRoom;
      - Pick up clothes
      -Throw out garbage
      - doors
    Calling methods
        "Hey go grean your room
void CleanYourRoom() returnType FunctionName() parameter     void = return nothing
    {
        Things to do;

    }
We can ask additional things
    CleanYourRoom(deadline)
        //This are things to do;
        -Do it before(deadline)
        -Pickup clother
        -Did you find "lost" Homework? (bool)
bool CleanYourRoom(int time)
    {
        things to do;
        Deadline = time;
        return false; cuz you already know it is false
        }
*/






