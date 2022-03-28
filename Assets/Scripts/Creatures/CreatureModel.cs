/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace BlackMountain.Creatures
{
    public class CreatureModel : MonoBehaviour
    {
        [Header("State")]
        public int health = 100;
        public int maxHealth = 100;
        public int armor = 0;
    }
}