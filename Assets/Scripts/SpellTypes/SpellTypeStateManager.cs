using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellTypeStateManager : MonoBehaviour {

    MonoBehaviour state;
    
    public void Start()
    {
        state = gameObject.AddComponent<ReadySpellTypeState>();
        
    }


    public void Select()
    {
        Destroy(state);
        state = gameObject.AddComponent<LoadingSpellTypeState>();
        
    }

    public void Ready()
    {
        Destroy(state);
        state = gameObject.AddComponent<ReadySpellTypeState>();

    }

    
}
