using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "MotherState")]

public class MotherState : ScriptableObject
{
    [SerializeField] public State[] states;

    public State GetFirstState()
    {
        var size = states.Length;
        if (size == 0)
        {
            return new State();
        }
        else
        {
            return states[size - 1];
        }
    }

    public virtual void LoadState(Text textComponent, Image imageComponent, Button[] buttonComponents, AdventureGame adventureGame)
    {
        // Debug.Log("LoadState " + this.GetInstanceID().ToString());
        Setup(this.GetFirstState(), textComponent, imageComponent, buttonComponents, adventureGame);    
    }

    public void Setup(State state, Text textComponent, Image imageComponent, Button[] buttonComponents, AdventureGame adventureGame)
    {
        textComponent.text = state.GetStateStory();
        imageComponent.sprite = state.ImageStateStory();

        for (int i = 0; i < buttonComponents.Length; i++)
        {
            if (state.GetSwitchInfo() != null && i < state.GetSwitchInfo().Length)
            {
                var buttonTxt = state.GetSwitchInfo()[i].buttonTxt;
                var motherState = state.GetSwitchInfo()[i].targetMotherState;
                buttonComponents[i].gameObject.SetActive(true);
                buttonComponents[i].GetComponentInChildren<Text>().text = buttonTxt;
                buttonComponents[i].GetComponentInChildren<Button>().onClick.AddListener ( delegate { adventureGame.LoadMotherState(motherState); });
            }
            else
            {
                buttonComponents[i].gameObject.SetActive(false);
            }
        }
    }
} 

