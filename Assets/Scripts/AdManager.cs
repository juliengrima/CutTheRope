using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class AdManager : MonoBehaviour, IUnityAdsInitializationListener
{
    #region Champs
    [SerializeField] string _androidGameId;
    [SerializeField] string _iOSGameId;
    [SerializeField] bool _testMode = true;
    private string _gameId;
    #endregion

    #region Default Informations
    void Reset()
    {
        _androidGameId = "5431270";
        _iOSGameId = "5431271";
        _gameId = "9071164673067";
    }
    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update
    
    void Awake()
    {
        InitializeAds();
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
    public void InitializeAds()
    {
        #if UNITY_IOS
                    _gameId = _iOSGameId;
        #elif UNITY_ANDROID
                _gameId = _androidGameId;
        #elif UNITY_EDITOR
                    _gameId = _androidGameId; //Only for testing the functionality in the Editor
        #endif
        if (!Advertisement.isInitialized && Advertisement.isSupported)
        {
            Advertisement.Initialize(_gameId, _testMode, this);
        }
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }
    #endregion
    #region Coroutines
    IEnumerator EndCoroutine()
    {
        throw new NotImplementedException();   
    }
    #endregion
}