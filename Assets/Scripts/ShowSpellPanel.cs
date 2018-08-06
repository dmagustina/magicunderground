using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSpellPanel : MonoBehaviour {

    public void OnClick(GameObject go)
    {
        go.SetActive(!go.activeSelf);
    }
}
