using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int playerClass;
    public int level;
    public int exp;
    public int expthreshold;
    public int maxhp;
    public int hp;
    public int atk;
    public int def;
    public float defmultiplier;
    public int mdef;
    public float mdefmultiplier;
    public int spd;
    public bool damageOverTime;
    public int damageOverTimeTurns;
    [SerializeField]
    private GameObject stat_text_obj;
    private TMP_Text stat_text;
    // Start is called before the first frame update
    void Start()
    {
        damageOverTime = false;
        damageOverTimeTurns = 0;
        stat_text = stat_text_obj.GetComponent<TMP_Text>();
        level = 1;
        expthreshold = 100;
        exp = 0;
        maxhp = 10;
        hp = 10;
        atk = 5;
        playerClass = 3;
        if (playerClass == 1)
        {
            defmultiplier = 1.5f;
            mdefmultiplier = 0.5f;
        }
        else if (playerClass == 2)
        {
            defmultiplier = 0.5f;
            mdefmultiplier = 1.5f;
        }
        else
        {
            defmultiplier = 1f;
            mdefmultiplier = 1f;
        }
        def = Mathf.FloorToInt(2 * defmultiplier);
        mdef = Mathf.FloorToInt(2 * mdefmultiplier);
        spd = 2;
    }

    // Update is called once per frame
    void Update()
    {
        stat_text.SetText($"Class: {playerClass}\nLevel: {level}\nEXP: {exp}/{expthreshold}\nHealth: {hp}\nAttack: {atk}\nDefense: {def}\nMagic Resistance: {mdef}\nSpeed: {spd}");
    }

    public void LevelUp()
    {
        if (exp >= expthreshold)
        {
            level += 1;
            maxhp = Mathf.FloorToInt(maxhp * 1.5f);
            atk = Mathf.FloorToInt(atk * 1.5f);
            def = Mathf.FloorToInt(def + 3 / defmultiplier);
            mdef = Mathf.FloorToInt(mdef + 3 / defmultiplier);
            spd = Mathf.FloorToInt(spd * 1.75f);
            expthreshold += 100 * level;
        }
    }

}
