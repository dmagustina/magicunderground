using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingHurtEnemyState : MonoBehaviour
{


    internal void SetDamage(float damage)
    {
        StartCoroutine(ReceiveDamages(damage));
    }

    IEnumerator ReceiveDamages(float damage)
    {
        gameObject.GetComponent<Enemy>().life -= damage;
        yield return new WaitForSeconds(0.3f);
        if (gameObject.GetComponent<Enemy>().life <= 0)
            gameObject.GetComponent<EnemyStateManager>().Died();
        else
            gameObject.GetComponent<EnemyStateManager>().KeepWalking();
    }

}