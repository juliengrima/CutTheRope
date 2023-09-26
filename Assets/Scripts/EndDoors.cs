using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class EndDoors : MonoBehaviour
{
    #region Champs
    [Header("Objects_Components")]
    [SerializeField] GameObject _stars;
    [SerializeField] GameObject _buttons;
    [Header("actions_Components")]
    [SerializeField] Animator _doorsAnimator;
    [SerializeField] UnityEvent _doorsEvent;
    [Header("Scenes_Names")]
    
    [Header("Event_Components")]
    [SerializeField] UnityEvent _ButtonsEnvents;
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
    public void ClosingDoors()
    {
        _doorsAnimator.SetTrigger("CLOSING");
    }
    #endregion
    #region Coroutines
    #endregion
}