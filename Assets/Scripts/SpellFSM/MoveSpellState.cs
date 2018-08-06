using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpellState : MonoBehaviour {

    private void Update()
    {
        Vector2 velocity = GetComponent<Spell>().destination - transform.position;
        if (velocity.magnitude < 0.1)
            GetComponent<SpellManager>().ArrivedPosition();
        else
            transform.position = Vector3.MoveTowards(transform.position, GetComponent<Spell>().destination, GetComponent<Spell>().speed * Time.deltaTime);
    }

}
