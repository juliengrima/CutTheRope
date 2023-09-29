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
    [SerializeField] string _menu;
    [SerializeField] string _next;
    #endregion
    #region Default Informations
    void Reset()
    {
        _menu = "Menu";
        _next = "Lev2";
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
        SceneManager.LoadScene(_menu); 
    }

    public void Next()
    {
        SceneManager.LoadScene(_next);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    #endregion
    #region Coroutines
    #endregion
}