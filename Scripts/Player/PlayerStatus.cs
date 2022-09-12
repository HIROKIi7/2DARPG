using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElementType;


namespace Player {

    public class PlayerStatus : MonoBehaviour
    {

        /// <summary>
        /// キャラクターのステータス一覧
        /// </summary>

        [SerializeField] private int _hp;
        [SerializeField] private int _hpMax;
        [SerializeField] private int _mp;
        [SerializeField] private int _mpMax;
        [SerializeField] private int _atk;
        [SerializeField] private int _def;
        [SerializeField] private int _vit;
        [SerializeField] private int _res;
        [SerializeField] private int _level;
        [SerializeField] private int _exp;
        [SerializeField] private int _needExp;
        [SerializeField] private bool _isAlive = true;

        /// <summary>
        /// キャラクターの状態
        /// </summary>
        public AbnormalState State => _State;
        [SerializeField] private AbnormalState _State = AbnormalState.Normal;


        public int HP
        {
            // 取得
            get { return _hp; }

            // 変更
            set { _hp = value; }
        }

        public int HPMAX
        {
            // 取得
            get { return _hpMax; }

            // 変更
            private set { _hpMax = value; }
        }

        public int MP
        {
            // 取得
            get { return _mp; }

            // 変更
            set { _mp = value; }
        }

        public int MPMAX
        {
            // 取得
            get { return _mpMax; }

            // 変更
            private set { _mpMax = value; }
        }

        public int ATK
        {
            // 取得
            get { return _atk; }

            // 変更
            set { _atk = value; }
        }

        public int DEF
        {
            // 取得
            get { return _def; }

            // 変更
            set { _def = value; }
        }

        public int VIT
        {
            // 取得
            get { return _vit; }

            // 変更
            set { _vit = value; }
        }

        public int RES
        {
            // 取得
            get { return _res; }

            // 変更
            set { _res = value; }
        }

        public int LEVEL
        {
            // 取得
            get { return _level; }

            // 変更
            set { _level = value; }
        }

        public int EXP
        {
            // 取得
            get { return _exp; }

            // 変更
            set { _exp = value; }
        }

        public bool ISALIVE
        {
            // 取得
            get { return _isAlive; }

            // 変更
            set { _isAlive = value; }
        }

        public AbnormalState STATE
        {
            // 取得
            get { return _State; }

            // 変更
            set { _State = value; }
        }

        public void NextExp()
        {
            _needExp = (int)(_needExp * 1.1);
        }
    }
}
