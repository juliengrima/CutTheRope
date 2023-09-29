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
    [Header("Components")]
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _candy;
    [SerializeField] GameObject _ropes;
    [SerializeField] EndDoors _doors;
    [Header("Filds")]
    [SerializeField] float _waitForDestroy;
    [SerializeField] float _waitForEnd;
    [Header("Events")]
    [SerializeField] UnityEvent _event;
    //Privates
    Coroutine _end;
    #endregion
    #region Enumerator
    #endregion
    #region Default Informations
    void Reset()
    {
        _waitForDestroy = 2f;
        _waitForEnd = 2f;
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
            _end = StartCoroutine(EndCoroutine());
        }
    }
    #endregion
    #region Coroutines
    IEnumerator EndCoroutine()
    {
        //throw new NotImplementedException();
        _event.Invoke();
        yield return new WaitForSeconds(_waitForDestroy);
        Destroy(_candy);
        _ropes.SetActive(false);

        // Chargez la scène actuelle à nouveau
        yield return new WaitForSeconds(_waitForEnd);
        _doors.ClosingDoors();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    #endregion
}