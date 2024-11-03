using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Basil Khalid -_-
        string multiplyString = ""; 
        for (int i = 1; i <= 10 ; i++)
        {
            Debug.Log("5 * " + i + " = " + Multiply(5 , i));
            multiplyString += ("5 * " + i + " = " + Multiply(5 , i) + " <--> ") ; // to print all of result in one line 

        }
        Debug.Log(multiplyString);
    }

    int Multiply (int num1 , int num2) {
        int result = num1 * num2 ;
        return result;
    }
}
