using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy {
    public class Enemy : MonoBehaviour
    {

        /// <summary>
        /// �\����
        /// </summary>
        public string DisplayName => _DisplayName;
        [SerializeField] private string _DisplayName = "";

        /// <summary>
        /// �ő�HP
        /// </summary>
        public int MaxHp => _MaxHp;
        [SerializeField] private int _MaxHp = 0;
        public int Hp { get; protected set; }

        /// <summary>
        /// ���݂�HP
        /// </summary>
        [SerializeField] private int _hp;
        public int HP { get; set; }

        /// <summary>
        /// �ő�MP
        /// </summary>
        public int MaxMp => _MaxMp;
        [SerializeField] private int _MaxMp = 0;
        public int Mp { get; set; }

        /// <summary>
        /// ���݂�MP
        /// </summary>
        [SerializeField] private int _mp;
        public int MP { get; set; }

        /// <summary>
        /// �U����
        /// </summary>
        public int Atk => _Atk;
        [SerializeField] private int _Atk = 0;

        /// <summary>
        /// �h���
        /// </summary>
        public int Def => _Def;
        [SerializeField] private int _Def = 0;

        /// <summary>
        /// ��
        /// </summary>
        public int Vit => _Vit;
        [SerializeField] private int _Vit = 0;

        /// <summary>
        /// ��R��
        /// </summary>
        public int Reg => _Reg;
        [SerializeField] private int _Reg = 0;

        /// <summary>
        /// �o���l
        /// </summary>

        public int Exp => _Exp;
        [SerializeField] private int _Exp = 0;

        /// <summary>
        /// ����
        /// </summary>   

        public int Gol => _Gol;
        [SerializeField] private int _Gol = 0;

        /// <summary>
        /// ���
        /// </summary>
        public enum AbnormalState
        {
            Normal,
            Faint
        }

        public AbnormalState State => _State;
        [SerializeField] private AbnormalState _State = AbnormalState.Normal;

        /// <summary>
        /// �n��
        /// </summary>
        public Breed Breed => _Breed;
        [SerializeField] private Breed _Breed = null;

        private void Awake()
        {
            _DisplayName = Breed._enemyName;
            _MaxHp = _hp = Breed._maxHp;
            _MaxMp = _mp = Breed._maxMp;
            _Atk = Breed._atk;
            _Def = Breed._def;
            _Vit = Breed._vit;
            _Reg = Breed._reg;
            _Exp = Breed._exp;
            _Gol = Breed._gold;
        }

        private void Update()
        {
            FindState();
        }

        public void FindState()
        {

            if (Mp <= 0) _State = AbnormalState.Faint;
            else _State = AbnormalState.Normal;

        }

        public void AutoMPRecovery()
        {
            if(MP >= MaxMp) { }
            else if(MP < MaxMp)
            {
                //�U�����󂯂Ă��邩�܂��́Z�U�����󂯂��ꍇ3�b�҂�
                /*
                if (�U�����󂯂��@�܂��́@�Z�U�����󂯂���)
                {
                    //3�b�҂�
                    yield return new WaitForSeconds(3);
                }
                else
                {
                    MP++;
                }
                */
            }
        }
    }
}


