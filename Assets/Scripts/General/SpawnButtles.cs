using UnityEngine;

public class SpawnButtles : MonoBehaviour
{
    [SerializeField] private Buttle _buttleTemplate;
    [SerializeField] private int _buttlesCount;
    [SerializeField] private float _buttlesOffset;
    [SerializeField] private Vector3 _startButtlePosition;
    [SerializeField] private Transform _buttleParent;
    [SerializeField] private PrimerController _primeController;

    private void Start()
    {
        Vector3 startSpawnPosition = _startButtlePosition;
        
        for (int i = 0; i < _buttlesCount; i++)
        {
            Buttle buttle = Instantiate(_buttleTemplate, _buttleParent);
            buttle.transform.localPosition = startSpawnPosition;
            startSpawnPosition = new Vector3(startSpawnPosition.x + buttle.transform.localScale.x + _buttlesOffset,
                startSpawnPosition.y,
                startSpawnPosition.z);
            buttle.Init(_primeController);
        }
    }
}