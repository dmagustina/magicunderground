using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour {
    private MonoBehaviour state;

    // Use this for initialization
    void Start()
    {
        state = gameObject.AddComponent<MoveSpellState>();
       
    }

    internal void ArrivedPosition()
    {
        Destroy(state);
        state = gameObject.AddComponent<DamageSpellState>();
    }
}
