using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    [SerializeField] GameObject warriorPrefab;

    public Text lvText;
    public Text hpText;
    public Text mpText;

    void Start()
    {
        Warrior warrior = Instantiate(warriorPrefab).GetComponent<Warrior>();

        lvText.text = warrior.level;
        hpText.text = warrior.hp.ToString();
        mpText.text = warrior.mp.ToString();
    }
    public void OnClickButton()
    {
        Debug.Log("작동");
    }
}
