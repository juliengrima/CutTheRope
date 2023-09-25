using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;


public class Around : MonoBehaviour
{
    #region Champs
    PlayerState _currentState;
    #endregion
    #region Enumerator
    public enum PlayerState
    {
        State1,
        State2,
        State3,
        State4,
        State5,
        State6,
        State7
    }
    #endregion
    #region Default Informations
    void Reset()
    {
        
    }
    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update
    
    void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Methods
    void FixedUpdate()
    {
        
    }
    void LateUpdate()
    {
        
    }
    #endregion
    #region StatesMachine
    void OnStateEnter()
    {
        switch (_currentState)
        {
            case PlayerState.State1:
               
                break;
            case PlayerState.State2:
                break;
            case PlayerState.State3:
                break;
            case PlayerState.State4:
               
                break;
            case PlayerState.State5:
               
                break;
            case PlayerState.State6:
               
                break;
            case PlayerState.State7:
                
                break;
            default:
                break;
        }
    }
    void OnStateUpdate()
    {
        switch (_currentState)
        {
            case PlayerState.State1: //Base statement 
                break;
            case PlayerState.State2: // State Start to move and make interactions
                break;
            case PlayerState.State3:
                break;
            case PlayerState.State4:
                break;
            case PlayerState.State6:    
                break;
            case PlayerState.State7:

                break;
            default:
                break;
        }
    }

    void OnStateExit()
    {
        switch (_currentState)
        {
            case PlayerState.State1:
              
                break;
            case PlayerState.State2:
               
                break;
            case PlayerState.State3:
                
                break;
            case PlayerState.State4:
                break;
            case PlayerState.State5:
                
                break;
            case PlayerState.State6:
               
                break;
            case PlayerState.State7:

                break;
            default:
                break;
        }
    }
    public void TransitionToState(PlayerState nextState)
    {
        OnStateExit();
        _currentState = nextState;
        OnStateEnter();
    }
    #endregion
    #region Coroutines
    #endregion
}