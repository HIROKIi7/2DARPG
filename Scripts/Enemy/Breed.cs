using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    [CreateAssetMenu]
    public class Breed : ScriptableObject
    {
        /// <summary>
        /// ånìùñº
        /// </summary>
        public string Name => _Name;
        [SerializeField] private string _Name = "";

        /// <summary>
        /// ê∂ëßín
        /// </summary>
        public string Habitat => _Habitat;
        [SerializeField] private string _Habitat = "";

    }
}
