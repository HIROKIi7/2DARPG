using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CreateEnemyParamAsset")]
    public class Breed : ScriptableObject
    {
        public string _enemyName;
        public int _maxHp;
        public int _maxMp;
        public int _atk;
        public int _def;
        public int _vit;
        public int _reg;
        public int _exp;
        public int _gold;

    }
}
