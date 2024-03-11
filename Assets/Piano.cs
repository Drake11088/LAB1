using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.VersionControl;
using UnityEngine;

public class Piano : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource _do, _re, _mi, _fa, _son, _la, _si;
    void Start()
    {
        Debug.Log(message: "start");
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent <AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource> ();
        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("son").GetComponent<AudioSource>() ;
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(message: "press A"); 
            _do.Play();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(message: "press S");
            _re.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(message: "press D");
            _mi.Play();
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(message: "press F");
            _fa.Play();
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(message: "Press G");
            _son.Play();
        }
    }
}
