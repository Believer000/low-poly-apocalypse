/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace BlackMountain
{
    public interface ITakeDamage
    {
        public void TakeDamage(int damage);

        public void Die();
    }
}