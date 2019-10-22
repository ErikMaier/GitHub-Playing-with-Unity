using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public int lebensEnergie = 100;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Die Figur hat noch " + lebensEnergie + " Lebensenergie" );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
