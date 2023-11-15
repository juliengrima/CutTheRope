using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class VisualRope : MonoBehaviour
{
    #region Champs
    [SerializeField] RopeAutoGenerate _rope;
    [SerializeField] LineRenderer _lineRenderer;
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
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //reduce variables
        var _link = _rope.List;
        var _hook = _rope.Hook;
        var _candy = _rope.Candy;
        // parcour liste de kook
        for (int i = 0; i < _hook.Count; i++)
        {
            // set lineRenderer at 
            _lineRenderer.SetPosition(0, _hook[i].transform.position);
            _lineRenderer.positionCount = _link.Count + 2;

            //parcour list de maillons pour donner la position de chacun a listRenderer
            for (int j = 0; j < _link.Count; j++)
            {
                if (_link[j] == null)
                {
                    _lineRenderer.SetPosition(j + 1, _link[j].transform.position);
                }
            }
        }
        _lineRenderer.SetPosition(_lineRenderer.positionCount-1, _candy.transform.position);
    }
    #endregion
    #region Methods
    void FixedUpdate()
    {
        
    }
    void LateUpdate()
    {
        
    }
    #endregion
    #region Coroutines
	IEnumerator EndCoroutine()
    {
        throw new NotImplementedException();   
    }
    #endregion
}