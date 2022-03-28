/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace BlackMountain.Creatures.Player
{
    public sealed class PlayerModel : CreatureModel
    {
        [Header("Movement")]
        public float rotationalSpeed = 3.0f;
        public float walkSpeed = 3.0f;
    }
}