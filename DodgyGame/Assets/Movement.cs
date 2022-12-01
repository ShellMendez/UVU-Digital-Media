using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame updat
    public string selection = "Yellow";

    void SwitchStatement(Collision other)
    {

            switch (selection)
            {
                case ("Blue"):
                    Debug.Log("It is  Blue");
                    break;
                case ("Yellow"):
                    Debug.Log("It is Yellow");
                    break;
                case ("Pink"):
                    Debug.Log("It is Pink");
                    break;
            }
     }

}

