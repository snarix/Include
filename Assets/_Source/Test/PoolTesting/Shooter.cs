using Include;
using UnityEngine;

namespace _Source.Test
{
    public class Shooter : MonoBehaviour
    {
        [SerializeField] private BulletConfig _config;
        [SerializeField] private Transform _bulletSpawnPoint;
        
        private CustomPool<Bullet> _bulletPool;

        private void Start()
        {
            _bulletPool = new CustomPool<Bullet>(_config.BulletPrefab, _config.PrewarmObjects);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Shoot();
        }

        private void Shoot()
        {
            var bullet = _bulletPool.Get();
            Vector3 direction = Vector3.up;
            bullet.Initialize(direction, _bulletPool, _bulletSpawnPoint.position);
        }
    }
}