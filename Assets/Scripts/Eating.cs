using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;


public class Eating : MonoBehaviour
{
    #region Champs
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _candy;
    [SerializeField] UnityEvent _event;
    #endregion
    #region Enumerator
    #endregion
    #region Default Informations
    void Reset()
    {

    }
    #endregion
    #region Unity LifeCycle
    #endregion
    #region Methods
    #endregion
    #region Triggers
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == null) return;
        if (collision.attachedRigidbody.gameObject.CompareTag(_candy.tag))
        {
            _event.Invoke();
        }
    }
    #endregion
    #region Coroutines
    #endregion
}