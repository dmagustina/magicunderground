using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour {

    public float life;
    public float resistense;

    public void getAttacked(float damage)
    {
        life -= damage-resistense;
    }


}
