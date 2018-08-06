using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyingEnemyState : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Animator>().SetTrigger("Die");
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(gameObject);
    }

}
