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
        [SerializeField] private bool _isAlive = true;

        /// <summary>
        /// キャラクターの状態
        /// </summary>
        [SerializeField] private AbnormalStatus _State = AbnormalStatus.NORMAL;


        public int HP { get => _hp; set => _hp = value; }

        public int HPMAX { get => _hpMax; set => _hpMax = value; }

        public int MP { get => _mp; set => _mp = value; }

        public int MPMAX { get => _mpMax; set => _mpMax = value; }

        public int ATK { get => _atk; set => _atk = value; }

        public int DEF { get => _def; set => _def = value; }

        public bool ISALIVE { get => _isAlive; set => _isAlive = value; } 

        public AbnormalStatus STATE { get => _State; set => _State = value; }

        public void Awake()
        {
            _hp = _hpMax;
        }

        private void Update()
        {
            FindAbnormal();
        }

        public void FindAbnormal()
        {
            if (_mp <= (int)(_mpMax * 0.33))
            {
                _State = AbnormalStatus.NORMAL;

            }
            if (_mp > (int)(_mpMax* 0.33) && _mp <= (int)(_mpMax  * 0.66))
            {
                _State = AbnormalStatus.NASTY;
            }
            if (_mp > (int)(_mpMax * 0.66) && _mp <= _mpMax )
            {
                _State = AbnormalStatus.FAINT;
            }
        }
    }
}
