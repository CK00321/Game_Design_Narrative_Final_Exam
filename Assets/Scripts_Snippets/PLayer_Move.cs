using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 2.50f;

    public GameObject TextE;

    void FixedUpdate()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");


        Vector2 Player = new Vector2(moveX, moveY);

        Player = Player.normalized * Speed * Time.deltaTime;

        transform.Translate(Player);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mimushi") || collision.gameObject.CompareTag("Mitushi")) 
        {
            Debug.Log("Enter_The_Dialogue");
            TextE.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Dialogue_System_Is_Unreachable");
        TextE.SetActive(false);
    }
}
