using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Player;

namespace UI
{
    public class Hud : MonoBehaviour
    {
        public Image _hpGauge; // HP ÉQÅ[ÉW

        GameObject _player;
        public PlayerStatus _playerstatus;

        // Update is called once per frame
        void Update()
        {
            var _hp = _playerstatus.HP;
            var _hpMax = _playerstatus.HPMAX;
            _hpGauge.fillAmount = (float)_hp / _hpMax;

        }
    }
}
