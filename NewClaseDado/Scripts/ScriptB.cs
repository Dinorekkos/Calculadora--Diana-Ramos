using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptB : MonoBehaviour
{
    [SerializeField] private string name;
    private ScriptA scriptA;

    void Start()
    {
        scriptA = FindObjectOfType<ScriptA>();
        scriptA.Function1(name);
    }


}
