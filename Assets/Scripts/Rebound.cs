using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Rebound : MonoBehaviour
{
    #region Champs
    [SerializeField] AudioSource _source;
    [SerializeField] AudioClip _clip;
    #endregion
    #region Default Informations
    #endregion
    #region Unity LifeCycle 
    #endregion
    #region Methods
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(EndCoroutine());
    }
    #endregion
    #region Coroutines
    IEnumerator EndCoroutine()
    {
        //throw new NotImplementedException();
        _source.PlayOneShot(_clip);
        yield return new WaitForSeconds(1f);
        _source.Stop();
    }
    #endregion
}