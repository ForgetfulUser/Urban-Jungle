using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Camera MainCamera;
    public bool isFollowing;
    public GameObject Player;
    public int MoveThreshold = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MainCamera = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {

            if (Player.transform.position.x > MainCamera.transform.position.x + MoveThreshold)
            {
                Vector3 newPos = MainCamera.transform.position;
                newPos.x = Player.transform.position.x - MoveThreshold;
                MainCamera.transform.position = newPos;
            }
            else if (Player.transform.position.x < MainCamera.transform.position.x - MoveThreshold)
            {
                Vector3 newPos = MainCamera.transform.position;
                newPos.x = Player.transform.position.x + MoveThreshold;
                MainCamera.transform.position = newPos;
            }
        }
    }
}
