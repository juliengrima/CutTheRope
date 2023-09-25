using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Eating : MonoBehaviour
{
    #region Champs
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _candy;
    [SerializeField] UnityEvent _event;
    Coroutine _end;
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
            _end = StartCoroutine(EndCoroutine());
        }
    }
    #endregion
    #region Coroutines
    IEnumerator EndCoroutine()
    {
        //throw new NotImplementedException();
        yield return new WaitForSeconds(2);
        // Chargez la scène actuelle à nouveau
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    #endregion
}