using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5.0f; 

    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");


        Vector2 Player = new Vector2(moveX, moveY);

        Player = Player.normalized * Speed * Time.deltaTime;

        transform.Translate(Player);
    }
}
