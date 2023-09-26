using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEditor;


public class Restart : MonoBehaviour
{
    #region Champs
    [SerializeField] InputActionReference _click;
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
    public void RestartScene()
    {
        if (_click.action.IsPressed())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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