using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellThrower : MonoBehaviour
{

    public SpellType SpellSelected;

    private static SpellThrower instance;

    public static SpellThrower Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<SpellThrower>();
            return instance;
        }
        set
        {
            instance = value;
        }

    }

    void Update()
    {
        Vector3 pos= Input.mousePosition;
        if (Input.GetMouseButtonDown(0) && SpellSelected != null && SpellSelected.isReady && Inside(pos))
        {
            SpellSelected.getFSM().Select();
            Vector2 position = Camera.main.ScreenToWorldPoint(pos);
            GameObject spell = Instantiate(Resources.Load("Prefab/" + SpellSelected.spell, typeof(GameObject))) as GameObject;
            spell.transform.position = new Vector3(position.x, Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).y, 0);
            spell.GetComponent<Spell>().destination = new Vector3(position.x, position.y, 0);
        }
    }

    private bool Inside(Vector3 pos)
    {
        Vector3 viewportPos = Camera.main.ScreenToViewportPoint(pos);
        if (viewportPos.y < 0.3)
            return false;


        return true;
    }
}
