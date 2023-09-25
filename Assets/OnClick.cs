using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class OnClick : MonoBehaviour
{
    #region Champs
    [SerializeField] InputActionReference _click;
    #endregion
    #region Enumerator
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
        if (_click.action.IsPressed())
        {
            gameObject.SetActive(false);
        }
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
    #region Coroutines
    #endregion
}