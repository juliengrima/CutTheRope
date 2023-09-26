using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Scoremanager : MonoBehaviour
{
    #region Champs
    [SerializeField] TextMeshProUGUI _scoreText;
    int _score = 0;
    int score;
    public static Scoremanager Instance { get; private set; }
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
        Instance = this;
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
    internal void AddScore(int amount)
    {
        _score += amount;
        _scoreText.text = _score.ToString();
        //Debug.Log($" Death count : {_score}");
    }
    #endregion
    #region Coroutines
    IEnumerator EndCoroutine()
    {
        throw new NotImplementedException();   
    }
    #endregion
}