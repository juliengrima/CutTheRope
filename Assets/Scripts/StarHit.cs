using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class StarHit : MonoBehaviour
{
    #region Champs
    [SerializeField] GameObject _candyTag;
    [SerializeField] UnityEvent _event;
    [SerializeField] int _score;
    [SerializeField] float _wait;
    #endregion
    #region Default Informations
    void Reset()
    {
        _score = 1;
        _wait = 1.5f;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == null) return;
        if (collision.attachedRigidbody.gameObject.CompareTag(_candyTag.tag))
        {
            Scoremanager.Instance.AddScore(_score);
            StartCoroutine(EnableDestroyAfterDelay());
        }
    }
    #endregion
    #region Coroutines
    IEnumerator EnableDestroyAfterDelay()
    {
        //throw new NotImplementedException();
        _event.Invoke();
        yield return new WaitForSeconds(_wait);
        Destroy(gameObject);
    }
    #endregion
}