using ButchersGames;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float yOffset;
    [SerializeField] private float cameraDistance;
    [SerializeField] private float cameraHeight;
    private Camera _camera;
    private Transform _target;
    private void Awake()
    {
        _camera = Camera.main;
        LevelManager.Default.OnLevelStarted += SetTarget;
    }
    private void OnDestroy()
    {
        LevelManager.Default.OnLevelStarted -= SetTarget;
    }
    private void SetTarget()
    {
        _target = LevelManager.Default.LeveL.Player.transform;
    }
    private void Update()
    {
        _camera.transform.position = _target.position - (_target.rotation * Vector3.forward * cameraDistance) + Vector3.up * cameraHeight;
        _camera.transform.LookAt(_target.position + Vector3.up * yOffset);       
        
    }
}
