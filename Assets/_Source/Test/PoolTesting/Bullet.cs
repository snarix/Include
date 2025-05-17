using Include;
using UnityEngine;

namespace _Source.Test
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private BulletConfig _config;
        
        private CustomPool<Bullet> _bulletPool;
        private Camera _camera;
        private Vector3 _direction;

        public void Initialize(Vector3 direction, CustomPool<Bullet> bulletPool, Vector3 spawnPosition)
        {
            _direction = direction;
            _bulletPool = bulletPool;
            _camera = Camera.main;
            transform.position = spawnPosition;
        }
        
        private void Update()
        {
            transform.position += _direction * (_config.BulletSpeed * Time.deltaTime);
            
            Vector3 viewportPos = _camera.WorldToViewportPoint(transform.position);
            if (viewportPos.x < 0 || viewportPos.x > 1 || viewportPos.y < 0 || viewportPos.y > 1)
                _bulletPool.Release(this);
        }
    }
}