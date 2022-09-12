using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy {
    public class Enemy : MonoBehaviour
    {

        /// <summary>
        /// ï\é¶ñº
        /// </summary>
        public string DisplayName => _DisplayName;
        [SerializeField] private string _DisplayName = "";

        /// <summary>
        /// ç≈ëÂHP
        /// </summary>
        public int MaxHp => _MaxHp;
        [SerializeField] private int _MaxHp = 0;
        public int Hp { get; protected set; }

        /// <summary>
        /// åªç›ÇÃHP
        /// </summary>
        [SerializeField] private int _hp;
        public int HP { get; set; }

        /// <summary>
        /// ç≈ëÂMP
        /// </summary>
        public int MaxMp => _MaxMp;
        [SerializeField] private int _MaxMp = 0;
        public int Mp { get; set; }

        /// <summary>
        /// åªç›ÇÃMP
        /// </summary>
        [SerializeField] private int _mp;
        public int MP { get; set; }

        /// <summary>
        /// çUåÇóÕ
        /// </summary>
        public int Atk => _Atk;
        [SerializeField] private int _Atk = 0;

        /// <summary>
        /// ñhå‰óÕ
        /// </summary>
        public int Def => _Def;
        [SerializeField] private int _Def = 0;

        /// <summary>
        /// óÕ
        /// </summary>
        public int Vit => _Vit;
        [SerializeField] private int _Vit = 0;

        /// <summary>
        /// íÔçRóÕ
        /// </summary>
        public int Res => _Res;
        [SerializeField] private int _Res = 0;

        /// <summary>
        /// èÛë‘
        /// </summary>
        public enum AbnormalState
        {
            Normal,
            Faint
        }

        public AbnormalState State => _State;
        [SerializeField] private AbnormalState _State = AbnormalState.Normal;

        /// <summary>
        /// ånìù
        /// </summary>
        public Breed Breed => _Breed;
        [SerializeField] private Breed _Breed = null;

        public void Awake()
        {
            _hp = _MaxHp;
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
                //çUåÇÇéÛÇØÇƒÇ¢ÇÈÇ©Ç‹ÇΩÇÕÅZçUåÇÇéÛÇØÇΩèÍçá3ïbë“Ç¬
                /*
                if (çUåÇÇéÛÇØÇΩÅ@Ç‹ÇΩÇÕÅ@ÅZçUåÇÇéÛÇØÇΩÇÁ)
                {
                    //3ïbë“Ç¬
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


