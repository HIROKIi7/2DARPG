using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Gmmick
{
    public class HDamageZone : MonoBehaviour
    {

        GameObject _player;
        public PlayerStatus _playerstatus;
        private float _bounce = 20f;

        private void OnCollisionEnter2D(Collision2D _collision)
        {
            if (_collision.gameObject.CompareTag("Player"))
            {
                _collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * _bounce, ForceMode2D.Impulse);
                _playerstatus.MP = _playerstatus.MP + 1;
            }
        }
    }
}
