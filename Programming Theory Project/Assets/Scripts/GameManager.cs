using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Filament Filament;
    public PLA PLA;
    public TextMeshProUGUI nozzleTempInput;
    public TextMeshProUGUI printStatusTxt;
    int temp;

    // Start is called before the first frame update
    void Start()
    {
        PLA = GameObject.Find("PLA").GetComponent<PLA>();
        Filament = GameObject.Find("Filament").GetComponent<Filament>();
        //printStatusTxt.text = "hello";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PLAButton()
    {
        printStatusTxt.text = PLA.Melt();
    }

    public void FilamentButton()
    {
        printStatusTxt.text = Filament.Melt();
    }
}