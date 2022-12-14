using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy {
    public class Enemy : MonoBehaviour
    {

        /// <summary>
        /// 表示名
        /// </summary>
        public string DisplayName => _DisplayName;
        [SerializeField] private string _DisplayName = "";

        /// <summary>
        /// 最大HP
        /// </summary>
        public int MaxHp => _MaxHp;
        [SerializeField] private int _MaxHp = 0;
        public int Hp { get; protected set; }

        /// <summary>
        /// 現在のHP
        /// </summary>
        [SerializeField] private int _hp;
        public int HP { get; set; }

        /// <summary>
        /// 最大MP
        /// </summary>
        public int MaxMp => _MaxMp;
        [SerializeField] private int _MaxMp = 0;
        public int Mp { get; set; }

        /// <summary>
        /// 現在のMP
        /// </summary>
        [SerializeField] private int _mp;
        public int MP { get; set; }

        /// <summary>
        /// 攻撃力
        /// </summary>
        public int Atk => _Atk;
        [SerializeField] private int _Atk = 0;

        /// <summary>
        /// 防御力
        /// </summary>
        public int Def => _Def;
        [SerializeField] private int _Def = 0;

        /// <summary>
        /// 力
        /// </summary>
        public int Vit => _Vit;
        [SerializeField] private int _Vit = 0;

        /// <summary>
        /// 抵抗力
        /// </summary>
        public int Reg => _Reg;
        [SerializeField] private int _Reg = 0;

        /// <summary>
        /// 経験値
        /// </summary>

        public int Exp => _Exp;
        [SerializeField] private int _Exp = 0;

        /// <summary>
        /// お金
        /// </summary>   

        public int Gol => _Gol;
        [SerializeField] private int _Gol = 0;

        /// <summary>
        /// 状態
        /// </summary>
        public enum AbnormalState
        {
            Normal,
            Faint
        }

        public AbnormalState State => _State;
        [SerializeField] private AbnormalState _State = AbnormalState.Normal;

        /// <summary>
        /// 系統
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
                //攻撃を受けているかまたは〇攻撃を受けた場合3秒待つ
                /*
                if (攻撃を受けた　または　〇攻撃を受けたら)
                {
                    //3秒待つ
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


