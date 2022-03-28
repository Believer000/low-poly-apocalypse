/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace BlackMountain.Creatures
{
    public class CreatureView : MonoBehaviour, ITakeDamage
    {
        private CreatureModel _creatureModel = null;

        public delegate void OnDie();
        public event OnDie OnDieEvent;

        private void Awake()
        {
            _creatureModel = GetComponent<CreatureModel>();
        }

        private void OnEnable()
        {
            OnDieEvent += Die;
        }

        private void OnDisable()
        {
            OnDieEvent -= Die;
        }

        public void TakeDamage(int damage)
        {
            _creatureModel.health -= damage;

            if(_creatureModel.health <= 0)
            {
                OnDieEvent?.Invoke();
            }
        }

        public void Die()
        {
            Debug.Log(transform.name + " DIED!");
            Destroy(gameObject);
        }
    }
}