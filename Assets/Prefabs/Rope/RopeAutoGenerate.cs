using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;


public class RopeAutoGenerate : MonoBehaviour
{
    #region Champs
    [Header("Ropes_Components")]
    [SerializeField] List<GameObject> _hook = new List<GameObject>();
    List<GameObject> _list = new List<GameObject>();
    [SerializeField] Transform _candy;
    [SerializeField] GameObject _prefabsLinks;
    [SerializeField] int _countLinks;
    [Header("Audio_Components")]
    [SerializeField] AudioSource _source;
    [SerializeField] AudioClip _clip;
    //Private
    float _jump;
    public List<GameObject> List { get => _list; }
    public List<GameObject> Hook { get => _hook; }
    public Transform Candy { get => _candy; }
    #endregion
    #region Default Informations
    void Reset()
    {
        _countLinks = 2;
    }
    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update
    
    void Awake()
    {
        //représente une portion de chaine
        _jump = 1f / (_countLinks + 1f);
    }
    void Start()
    {
        LinksChains();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Methods
    void LinksChains()
    {
        // On parcours toutes ancres
        for (int j = 0; j < _hook.Count; j++)
        {
            var start = _hook[j].GetComponent<Rigidbody2D>();
            _list.Clear();

            // boucle de génération de chaine
            for (int i = 0; i < _countLinks; i++)
            {
                var jump = (i + 1f) * _jump;
                var pos = Vector3.Lerp(_hook[j].transform.position, _candy.position, jump);
                //creation chaine avec position des maillons
                // Quaternion.identity = Pas de rotation
                GameObject link = Instantiate(_prefabsLinks, pos, Quaternion.identity, transform);
                var jointRb2d = link.AddComponent<Rigidbody2D>();
                var jointCollider2d = jointRb2d.AddComponent<CircleCollider2D>();
                var joint = jointCollider2d.AddComponent<HingeJoint2D>();
                _list.Add(link);

                if (i == 0)
                {
                    if (start != null && joint != null)
                    {
                        joint.connectedBody = start;
                    }
                    else
                    {
                        Debug.Log($"La variable START est : {start}");
                        Debug.Log($"La variable JOINT est : {joint}");
                    }
                }
                else
                {
                    joint.connectedBody = _list[i - 1].GetComponent<Rigidbody2D>();
                }
            }
            var end = _candy.GetComponent<Rigidbody2D>();
            end.AddComponent<HingeJoint2D>().connectedBody = _list[_list.Count - 1].GetComponent<Rigidbody2D>();
        }
        _source.PlayOneShot(_clip);
    }
    #endregion
    #region Coroutines
	IEnumerator EndCoroutine()
    {
        throw new NotImplementedException();   
    }
    #endregion
}