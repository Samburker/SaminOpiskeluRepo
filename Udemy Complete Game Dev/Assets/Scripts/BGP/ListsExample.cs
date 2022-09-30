using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsExample : MonoBehaviour
{
    //tehd‰‰n string tyyppinen lista nimelt‰ stringlista
    List<string> stringlista = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        //lis‰t‰‰n JORMA stringlistaan
        stringlista.Add("JORMA");
        stringlista.Add("IRMELI");
        stringlista.Add("JAAKKIMA");
        Debug.Log(stringlista[0]);
        //poistetaan JORMA stringlistasta
        stringlista.Remove("JORMA");
        Debug.Log(stringlista[0]);
        // lis‰t‰‰n kakkospaikalle MANUEL
        stringlista.Insert(1, "MANUEL");
        Debug.Log(stringlista[1]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
