using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "MotherState")]

public class MotherState : ScriptableObject
{
    [SerializeField] public State[] states;

    private void Awake()
    {
        Debug.Log("Algo ai Awake" + this.GetInstanceID().ToString());
    }

    void Start()
    {
        Debug.Log("Algo ai Start" + this.GetInstanceID().ToString());
    }

    void Update()
    {
        Debug.Log(this.GetInstanceID().ToString());

    }

    public State GetFirstState()
    {
        var size = states.Length;
        if (size == 0)
        {
            Debug.Log("Algo ai GetFirst");

            return new State();
        }
        else
        {
            return states[size - 1];
        }
    }
    public virtual void LoadStates(Text textComponent, Image imageComponent, Button[] buttonComponents)
    {
        Debug.Log("Algo ai LoadStates" + this.GetInstanceID().ToString());
        Load(this.GetFirstState(), textComponent, imageComponent, buttonComponents);    
    }
    public void Load(State state, Text textComponent, Image imageComponent, Button[] buttonComponents)
    {
        textComponent.text = state.GetStateStory();
        imageComponent.sprite = state.ImageStateStory();

        for (int i = 0; i < buttonComponents.Length; i++)
        {
            if (state.GetSwitchInfo() != null && i < state.GetSwitchInfo().Length)
            {
                buttonComponents[i].gameObject.SetActive(true);
                buttonComponents[i].GetComponentInChildren<Text>().text = state.GetSwitchInfo()[i].buttonTxt;
               // buttonComponents[i].GetComponentInChildren<MotherState>() = state.GetSwitchInfo()[i].targetMotherState;
            }
            else
            {
                buttonComponents[i].gameObject.SetActive(false);
            }
        }
    }
} 

