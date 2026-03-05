using UnityEngine;
using UnityEngine.InputSystem;

public class MultiplayerManager : MonoBehaviour
{
    public InputActionAsset inputActions;

    [Header("Player Transforms")]
    public Transform player1SpawnPoint;
    public Transform player2SpawnPoint;
    public Transform player3SpawnPoint;
    public Transform player4SpawnPoint;

    [Header("Player Prefabs")]
    [SerializeField] private GameObject player1Prefab;
    [SerializeField] private GameObject player2Prefab;
    [SerializeField] private GameObject player3Prefab;
    [SerializeField] private GameObject player4Prefab;

    void Awake()
    {
        // TODO: Initialize player prefabs
        
        // Spawn in players
        GameObject player1 = Instantiate(player1Prefab, player1SpawnPoint.transform.position, player1SpawnPoint.transform.rotation);
        player1.AddComponent<PlayerInput>();
        player1.GetComponent<PlayerInput>().actions = inputActions;

        GameObject player2 = Instantiate(player2Prefab, player2SpawnPoint.transform.position, player2SpawnPoint.transform.rotation);
        player2.AddComponent<PlayerInput>();
        player2.GetComponent<PlayerInput>().actions = inputActions;

        // GameObject player3 = Instantiate(player3Prefab, player3SpawnPoint.transform.position, player3SpawnPoint.transform.rotation);
        // player3.AddComponent<PlayerInput>();
        // player3.GetComponent<PlayerInput>().actions = inputActions;

        // GameObject player4 = Instantiate(player4Prefab, player4SpawnPoint.transform.position, player4SpawnPoint.transform.rotation);
        // player4.AddComponent<PlayerInput>();
        // player4.GetComponent<PlayerInput>().actions = inputActions;
    }
}
