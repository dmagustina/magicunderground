using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellType : MonoBehaviour {

    public float coolDown;
    public string spell;
    public SpellTypeStateManager fsm;
    public Button button;

    public bool isReady { get; internal set; }

    public SpellTypeStateManager getFSM()
    {
        return fsm;
    }



}
