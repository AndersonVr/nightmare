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

    public virtual void LoadState(AdventureGame adventureGame)
    {
        Setup(this.GetFirstState(), adventureGame);    
    }

    public void Setup(State state, AdventureGame adventureGame)
    {
        adventureGame.textComponent.text = state.GetStateStory();
        adventureGame.imageComponent.sprite = state.ImageStateStory();

        for (int i = 0; i < adventureGame.buttonComponents.Length; i++)
        {
            if (state.GetSwitchInfo() != null && i < state.GetSwitchInfo().Length)
            {
                var buttonTxt = state.GetSwitchInfo()[i].buttonTxt;
                var motherState = state.GetSwitchInfo()[i].targetMotherState;
                adventureGame.buttonComponents[i].gameObject.SetActive(true);
                adventureGame.buttonComponents[i].GetComponentInChildren<Text>().text = buttonTxt;
                adventureGame.buttonComponents[i].GetComponentInChildren<Button>().onClick.RemoveAllListeners();
                adventureGame.buttonComponents[i].GetComponentInChildren<Button>().onClick.AddListener ( delegate
                {
                    adventureGame.LoadMotherState(motherState);
                });
            }
            else
            {
                adventureGame.buttonComponents[i].gameObject.SetActive(false);
            }
        }
    }
} 

