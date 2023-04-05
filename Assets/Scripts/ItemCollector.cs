using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    [SerializeField] private TMP_Text cherriesText;
    [SerializeField] private AudioSource collectionSoundEffect;
    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        collectionSoundEffect.Play(); 
        if(other.gameObject.CompareTag("Cherry")){
            Destroy(other.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
         }
    }
}
