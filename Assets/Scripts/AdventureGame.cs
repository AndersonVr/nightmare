using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] Image imageComponent;
    [SerializeField] MotherState startingState;
    [SerializeField] Button[] buttonComponents;

    void Start()
    {
        LoadMotherState(startingState);
    }

    public void LoadMotherState(MotherState motherState)
    {
        motherState.LoadState(textComponent, imageComponent, buttonComponents, this);
    }

}
