using UnityEngine;

namespace ButchersGames
{
    public class Level : MonoBehaviour
    {
        public Player Player => player;
        [SerializeField] private Transform playerSpawnPoint;
        [SerializeField] private Player player;
        
#if UNITY_EDITOR
        private void OnDrawGizmos()
    {
        if (playerSpawnPoint != null)
        {
            Gizmos.color = Color.magenta;
            var m = Gizmos.matrix;
            Gizmos.matrix = playerSpawnPoint.localToWorldMatrix;
            Gizmos.DrawSphere(Vector3.up * 0.5f + Vector3.forward, 0.5f);
            Gizmos.DrawCube(Vector3.up * 0.5f, Vector3.one);
            Gizmos.matrix = m;
        }
    }
#endif
    }
}