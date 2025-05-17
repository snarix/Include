using UnityEngine;

namespace _Source.Test
{
    [CreateAssetMenu(fileName = "BulletConfig", menuName = "BulletConfig")]
    public class BulletConfig : ScriptableObject
    {
        [field: SerializeField] public Bullet BulletPrefab { get; private set; }
        [field: SerializeField] public int PrewarmObjects { get; private set; }
        [field: SerializeField] public float BulletSpeed { get; private set; }
    }
}