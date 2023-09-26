using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class OnClick : MonoBehaviour, IPointerEnterHandler
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

    }
    #endregion
    #region Methods
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter"); 
        Destroy(gameObject);
    }

    //public void OnPointerClick(PointerEventData eventData)
    //{
    //    //throw new NotImplementedException();
    //    if (_click.action.IsPressed())
    //    {
    //        Destroy(gameObject);
    //    }
    //}
    #endregion
    #region Coroutines
    #endregion
}