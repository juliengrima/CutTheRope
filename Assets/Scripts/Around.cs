using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;


public class Around : MonoBehaviour
{
    #region Champs
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _candy;
    [SerializeField] float _wait;

    Coroutine _Animation;
    bool _candyDetected;
    #endregion
    #region Enumerator
    #endregion
    #region Default Informations
    void Reset()
    {
        _wait = 1f;
        _candyDetected = false;
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
            _candyDetected = true;
            _animator.SetBool("AROUNDENTER", _candyDetected);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == null) return;
        if (collision.attachedRigidbody.gameObject.CompareTag(_candy.tag))
        {
            _candyDetected = false;
            _animator.SetBool("AROUNDENTER", _candyDetected);
            _Animation = StartCoroutine(AnimationCoroutine());
        }
    }
    #endregion
    #region Coroutines
    IEnumerator AnimationCoroutine()
    {
        //throw new NotImplementedException();
        _animator.SetTrigger("AROUNDEXIST");
        yield return new WaitForSeconds(_wait);
        _animator.SetTrigger("IDLE");
    }
    #endregion
}