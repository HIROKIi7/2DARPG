using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElementType;


namespace Player {

    public class PlayerStatus : MonoBehaviour
    {

        /// <summary>
        /// �L�����N�^�[�̃X�e�[�^�X�ꗗ
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
        /// �L�����N�^�[�̏��
        /// </summary>
        public AbnormalState State => _State;
        [SerializeField] private AbnormalState _State = AbnormalState.Normal;


        public int HP
        {
            // �擾
            get { return _hp; }

            // �ύX
            set { _hp = value; }
        }

        public int HPMAX
        {
            // �擾
            get { return _hpMax; }

            // �ύX
            private set { _hpMax = value; }
        }

        public int MP
        {
            // �擾
            get { return _mp; }

            // �ύX
            set { _mp = value; }
        }

        public int MPMAX
        {
            // �擾
            get { return _mpMax; }

            // �ύX
            private set { _mpMax = value; }
        }

        public int ATK
        {
            // �擾
            get { return _atk; }

            // �ύX
            set { _atk = value; }
        }

        public int DEF
        {
            // �擾
            get { return _def; }

            // �ύX
            set { _def = value; }
        }

        public int VIT
        {
            // �擾
            get { return _vit; }

            // �ύX
            set { _vit = value; }
        }

        public int RES
        {
            // �擾
            get { return _res; }

            // �ύX
            set { _res = value; }
        }

        public int LEVEL
        {
            // �擾
            get { return _level; }

            // �ύX
            set { _level = value; }
        }

        public int EXP
        {
            // �擾
            get { return _exp; }

            // �ύX
            set { _exp = value; }
        }

        public bool ISALIVE
        {
            // �擾
            get { return _isAlive; }

            // �ύX
            set { _isAlive = value; }
        }

        public AbnormalState STATE
        {
            // �擾
            get { return _State; }

            // �ύX
            set { _State = value; }
        }

        public void NextExp()
        {
            _needExp = (int)(_needExp * 1.1);
        }
    }
}
