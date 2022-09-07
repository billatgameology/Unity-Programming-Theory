using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filament : MonoBehaviour
{
    float diameter;
    float cost;
    public int meltTemp = 230;
    public int remainingMM;
    Color color;

    public void StickToBed()
    {

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

    public bool RunOut(int requiredMM)
    {
        if(requiredMM <= remainingMM)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}