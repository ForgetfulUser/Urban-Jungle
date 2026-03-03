using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public CameraMovement CameraMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CameraMovement.StartCamMovement(Player);
    }

    // Update is called once per frame
    void Update()
    {
        CameraMovement.UpdateCamMovement();
    }
}
