using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerOnePrefab;
    public GameObject playerTwoPrefab;

    public void spawnPlayerOne()
    {
        PlayerInput.Instantiate(prefab: playerOnePrefab, playerIndex: 0, controlScheme: "Player01", pairWithDevice: Keyboard.current, splitScreenIndex: 0);
    }
    public void spawnPlayerTwo()
    {
        PlayerInput.Instantiate(prefab: playerTwoPrefab, playerIndex: 1, controlScheme: "Player02", pairWithDevice: Keyboard.current, splitScreenIndex: 1);
    }

    void Start()
    {
        spawnPlayerOne();
        spawnPlayerTwo();
    }

}
