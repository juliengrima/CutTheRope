using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class EndDoors : MonoBehaviour
{
    #region Champs
    [Header("actions_Components")]
    [SerializeField] Animator _doorsAnimator;
    [SerializeField] float _wait;
    [Header("Audio_Components")]
    [SerializeField] AudioSource _source;
    [SerializeField] AudioClip _clip;
    #endregion
    #region Default Informations
    void Reset()
    {
     
    }
    #endregion
    #region Unity LifeCycle
    #endregion
    #region Methods
    public void ClosingDoors()
    {
        _doorsAnimator.SetTrigger("CLOSING");
        StartCoroutine(Finished());
    }
    #endregion
    #region Coroutines
    IEnumerator Finished()
    {
        //throw new NotImplementedException();
        yield return new WaitForSeconds(_wait);
        _source.PlayOneShot(_clip);
    }
    #endregion
}