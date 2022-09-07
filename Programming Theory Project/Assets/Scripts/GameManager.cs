using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Filament Filament;
    public PLA PLA;
    public TextMeshProUGUI nozzleTempInput;
    public TextMeshProUGUI printStatusTxt;
    public Slider slider;
    public float temp;

    // Start is called before the first frame update
    void Start()
    {
        PLA = GameObject.Find("PLA").GetComponent<PLA>();
        Filament = GameObject.Find("Filament").GetComponent<Filament>();
        
        //inheritance stick to bed is method defined in parent class
        Debug.Log(PLA.StickToBed("PEI"));
        Debug.Log(PLA.StickToBed("Satin"));
        Debug.Log(PLA.StickToBed(15));
        Debug.Log(PLA.StickToBed(88));
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Polymorphy
    public void PLAButton()
    {
        printStatusTxt.text = PLA.Melt();
        GetNozzleTemp();
        if(PLA.HotEnough(temp))
        {
            Debug.Log("hot enough");
        }
        else 
        {
            Debug.Log("not hot enough");
        }
    }

    public void FilamentButton()
    {
        printStatusTxt.text = Filament.Melt();
        GetNozzleTemp();
        if(Filament.HotEnough(temp))
        {
            Debug.Log("hot enough");
        }
        else 
        {
            Debug.Log("not hot enough");
        }
    }

    public void GetNozzleTemp()
    {
        //temp = Convert.ToInt32(nozzleTempInput.text);
        temp = slider.value;
        Debug.Log(temp);
    }
}
