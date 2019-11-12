using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    [SerializeField] Sprite[] sprite;
    [SerializeField] Image map;

    private void Awake()
    {
        sprite = Resources.LoadAll<Sprite>("maps");

        map.sprite = sprite[Random.Range(1,5)];
    }
}
