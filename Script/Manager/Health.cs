using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Manager
{

    public class Health : MonoBehaviour
    {
        GameObject player;
        public PlayerStatus playerstatus;

        // Update is called once per frame
        void Update()
        {
            if(playerstatus.HP < 0)
            {
                playerstatus.ISALIVE = false;
            }
        }
    }
}
