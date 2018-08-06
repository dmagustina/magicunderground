using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadySpellTypeState : MonoBehaviour {
    UnityEngine.Events.UnityAction action;
    public void Start()
    {
        GetComponent<SpellType>().isReady = true;
        action = () => { OnClick(); };
        GetComponent<SpellType>().button.onClick.AddListener(action);


        GetComponent<Animator>().SetTrigger("changed");
    }


    public void OnClick()
    {

        SpellThrower.Instance.SpellSelected = GetComponent<SpellType>();

    }
    public void OnDestroy()
    {
        GetComponent<SpellType>().button.onClick.AddListener(action);
    }



}
