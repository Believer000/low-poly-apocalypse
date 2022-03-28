/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace BlackMountain.Creatures.Player
{
    public sealed class PlayerController : MonoBehaviour
    {
        private PlayerModel _model = null;
        private PlayerView _view = null;

        private void Awake()
        {
            _model = GetComponent<PlayerModel>();
            _view = GetComponent<PlayerView>();
        }

        private void Update()
        {
            _view.Move();
            _view.FollowCursor();
        }
    }
}