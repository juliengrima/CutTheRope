using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    #region Champs
    [SerializeField] InputActionReference _click;
    [SerializeField] string _menu;
    #endregion
    #region Default Informations
    void Reset()
    {
        _menu = "Menu";
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
    public void LoadMenu()
    {
        if (_click.action.IsPressed())
        {
            SceneManager.LoadScene(_menu);
        }
        
    }
    #endregion
    #region Coroutines
    #endregion
}