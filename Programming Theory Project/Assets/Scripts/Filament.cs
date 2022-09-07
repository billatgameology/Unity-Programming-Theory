using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filament : MonoBehaviour
{
    float diameter;
    float cost;
    public float meltTemp = 230f;
    public int remainingMM {get; private set;}
    
    
    Color color;

    public string Brand {get; set;}

    public void SetRemainingMM()
    {
        remainingMM = 99;
    }

    public void PrintObject()
    {

    }

    // polymorphy
    public virtual string Melt()
    {
        return "Filament is melting";
    }
    // overloading
    public virtual string StickToBed(string bedType)
    {
        if(bedType == "PEI")
        {
            return "PEI Sticks";
        }
        else
        {
            return "normal bed okay";
        }
    }

    public virtual string StickToBed(int bedTemp)
    {
        if(bedTemp>50)
        {
            return "that's hot bed";
        }
        else
        {
            return "cool bed is okay";
        }
    }

    //abstraction
    public bool HotEnough(float nozzleTempInput)
    {
        if(nozzleTempInput <= meltTemp)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}