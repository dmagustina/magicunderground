using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingSpellTypeState : MonoBehaviour {

    Image image;

    // Use this for initialization
    void Start()
    {
        image = transform.parent.GetComponent<Image>();
        GetComponent<Animator>().SetTrigger("changed");
        StartCoroutine(Loading());
    }

    public float load;

    private void Update()
    {
        load += Time.deltaTime;
        image.fillAmount = load / GetComponent<SpellType>().coolDown;

    }

    IEnumerator Loading()
    {
        GetComponent<SpellType>().isReady = false;
        yield return new WaitForSeconds(GetComponent<SpellType>().coolDown);
        GetComponent<SpellTypeStateManager>().Ready();
        
    }

}
