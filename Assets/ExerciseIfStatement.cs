using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseIfStatement : MonoBehaviour
{

    public bool condition;
    public string text;
    public string text2;
    public int score;
    public int location;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //var wert = Random.Range(5f,15f);

         /*if (condition)
        {
            Debug.Log("Diese Aussage (Condition) ist richtig!");
            
        }
        else
        {
            Debug.Log("Diese Aussage ist (Condition) ist falsch");
        }  */

        //Debug.Log(wert); 

        //Es werden zwei Werte zu einander verglichen
         /*if (wert > 10)
        {
            Debug.Log("Der Wert ist über 10");
            
        }
        else
        {
            Debug.Log("Der Wert ist unter 10");
        }  */
        
        // == vergleicht zwei bzw. && addiert einen wert zu den den zu vergleichenden Werten
        /*if (text == text2 && condition)
        {
            Debug.Log("Beide Konditionen sind richtig");
        }*/
        //  || = alt + 7, || ist der oder/or operator
        /*if (text == text2 || condition)
        {
            Debug.Log("Eine der beiden Konditionen ist richtig");
        }
        else
        {
            Debug.Log("Keine der beiden Konditionen ist richtig");
        }*/

        

        if (score == 20)
        {
            if (location == 5)
            {
                Debug.Log("WIN");
            }
        }
    }
    void OnValidate()
    {
        /*if (text == text2)
        {
            Debug.Log("Text 1 entspricht Text2");
        }
        else
        {
            Debug.Log("Text 1 entspricht *NICHT* Text 2");
        }*/
    }
}
