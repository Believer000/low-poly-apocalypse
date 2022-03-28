/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace BlackMountain.Creatures.Player
{
    [RequireComponent(typeof(PlayerModel))]
    [RequireComponent(typeof(CharacterController))]
    public sealed class PlayerView : CreatureView
    {
        private PlayerModel _model = null;

        private Animator _animator = null;
        private CharacterController _characterController = null;

        private void Awake()
        {
            _model = GetComponent<PlayerModel>();

            _animator = GetComponent<Animator>();
            _characterController = GetComponent<CharacterController>();
        }

        public void FollowCursor()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 targetDirection = hit.point - transform.position;
                float singleStep = _model.rotationalSpeed * Time.deltaTime;

                Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

                transform.rotation = Quaternion.LookRotation(newDirection);
                transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
            }
        }

        public void Move()
        {
            var deltaX = Input.GetAxisRaw("Horizontal") * _model.walkSpeed;
            var deltaZ = Input.GetAxisRaw("Vertical") * _model.walkSpeed;

            _animator.SetFloat("HorizontalSpeed", deltaX);
            _animator.SetFloat("VerticalSpeed", Mathf.Approximately(deltaX, 0) ? deltaZ : 0);

            var movement = new Vector3(deltaX, 0, deltaZ);
            movement = Vector3.ClampMagnitude(movement, _model.walkSpeed);
            movement = transform.TransformDirection(movement);

            _characterController.Move(movement * Time.deltaTime);
        }
    }
}