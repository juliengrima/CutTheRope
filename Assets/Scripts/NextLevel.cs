using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    #region Champs
    [SerializeField] InputActionReference _click;
    [SerializeField] string _next;
    #endregion
    #region Default Informations
    void Reset()
    {
        _next = "Menu";
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
    public void Next()
    {
        if (_click.action.IsPressed())
        {
            SceneManager.LoadScene(_next);
        }
    }
    #endregion
    #region Coroutines
    IEnumerator EndCoroutine()
    {
        throw new NotImplementedException();   
    }
    #endregion
}