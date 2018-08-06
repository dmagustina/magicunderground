using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DamageSpellState : MonoBehaviour {

    public ContactFilter2D contactFilter = new ContactFilter2D();

    public  void Start() {
        changeSprite();
        StartCoroutine(DamageEnemies());
    }

    private void changeSprite()
    {
        GetComponent<Animator>().SetTrigger("magic");
    }

    IEnumerator DamageEnemies()
    {
        string[] aux = { "enemy" };
        int i = LayerMask.GetMask(aux);
        

        Collider2D myCollider = gameObject.GetComponent<Collider2D>();
        int numColliders = 10;
        Collider2D[] colliders = new Collider2D[numColliders];
        
        contactFilter.SetLayerMask(i);
        contactFilter.useLayerMask = true;
        contactFilter.useTriggers = true;
        yield return new WaitForSeconds(0.3f);
        Physics2D.OverlapCollider(myCollider,contactFilter, colliders);

        foreach (Collider2D col in colliders)
        {
            
            if (col != null && col.CompareTag("enemy"))
            {
                EnemyStateManager enemy = col.GetComponent<EnemyStateManager>();
                enemy.GetsHurt(gameObject.GetComponent<Spell>().damage);
            }
        }
        Destroy(gameObject);
    }

    public static Texture2D LoadTexture(string FilePath)
    {

        // Load a PNG or JPG file from disk to a Texture2D
        // Returns null if load fails

        Texture2D Tex2D;
        byte[] FileData;

        if (File.Exists(FilePath))
        {
            FileData = File.ReadAllBytes(FilePath);
            Tex2D = new Texture2D(2, 2);           // Create new "empty" texture
            if (Tex2D.LoadImage(FileData))           // Load the imagedata into the texture (size is set automatically)
                return Tex2D;                 // If data = readable -> return texture
        }
        return null;                     // Return null if load failed
    }

}
