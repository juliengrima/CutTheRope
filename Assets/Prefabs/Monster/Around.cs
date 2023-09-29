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
    [Header("Around_Components")]
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _candy;
    [SerializeField] float _wait;
    [Header("Audio_Monster")]
    [SerializeField] AudioSource _source;
    [SerializeField] AudioClip _clipEnter;
    [SerializeField] AudioClip _clipExit;
    [SerializeField] AudioClip _clipClose;
    [SerializeField] float _waitAudio;

    Coroutine _Animation;
    Coroutine _Audio;
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
            _Audio = StartCoroutine(AudioCoroutine());
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
        _source.PlayOneShot(_clipClose);
        yield return new WaitForSeconds(_waitAudio);
        _source.PlayOneShot(_clipExit);
        yield return new WaitForSeconds(_wait);
        _animator.SetTrigger("IDLE");
    }

    IEnumerator AudioCoroutine()
    {
        //throw new NotImplementedException();
        yield return new WaitForSeconds(_waitAudio);
        _source.PlayOneShot(_clipEnter);
    }
    #endregion
}