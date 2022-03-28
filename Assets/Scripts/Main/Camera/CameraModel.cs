/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace BlackMountain
{
    public sealed class CameraModel : MonoBehaviour
    {
        public Transform target = null;
        public float followSpeed = 3.0f;
        public Vector3 offset = Vector3.zero;
    }
}