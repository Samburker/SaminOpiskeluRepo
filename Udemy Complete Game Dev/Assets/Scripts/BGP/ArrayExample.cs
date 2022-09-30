using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // to create integer type of array which can hold 4 numbers
    int[] numberArray = new int[4];


    // Tehd‰‰n string tyyppinen array nimelt‰‰n names. sis‰lt‰‰ kolme stringi‰ HEHE.
    string[] names = new string[3];

    // Tehd‰‰n string tyyppinen array nimelt‰‰n names2. Sis‰lt‰‰ 5 stringi‰.
    string[] names2 = { "Sami", "Jorma", "Seppo", "Erkki", "Kalle" };

    // uusi esimerkki
    public GameObject[] players;

    
    void Start()
    {
        //Arrayn ensimm‰inen numero asetetaan = 10 (aloitetaan nollasta, 1 on toinen jne.)
        numberArray[0] = 10;
        numberArray[1] = 20;
        numberArray[2] = 30;
        numberArray[3] = 40;
        // tehd‰‰n uusi string muuttuja nimelt‰ bestnames ja t‰ytet‰‰n se arraylla names2
        foreach (string bestnames in names2)
        {
            Debug.Log("Parhaat suomalaiset nimet on : " + bestnames);
        }

        Debug.Log("Arrayn ensimm‰inen numero on: " +numberArray[0]);

        // t‰ytet‰‰n players array kahdella gameobjektilla joilla on tagi "Player"
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    
    void Update()
    {
        
    }
}
