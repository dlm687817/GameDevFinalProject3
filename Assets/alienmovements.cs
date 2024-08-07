using UnityEngine;

public class Alienmovements : MonoBehaviour
{
    public float speed = 5f; 
    [SerializeField] string CreatureName = "Moonflower";
    [SerializeField] float jumpForce = 5f;
    private Rigidbody2D rb;
    [SerializeField] SpriteRenderer spriteRenderer;

    [SerializeField] Sprite jumpingLeft;
    [SerializeField] Sprite jumpingRight;
    [SerializeField] Sprite mainCharacter;
    [SerializeField] Sprite mainCharacterBack;
    private float groundRadius = 0.1f;
    private bool isGrounded = true;
    [SerializeField] GameObject groundCheck;
    [SerializeField] LayerMask groundLayer;

    [SerializeField] Vector3 homePosition = Vector3.zero;
    public enum Buttonmovements { tf, physics };
    [SerializeField] Buttonmovements movementType = Buttonmovements.tf;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    public void PlayerShifts(Vector3 direction)
    {
        direction.Normalize();
        transform.position += direction * speed * Time.deltaTime;

        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            
            if (direction.x < 0)
            {
                spriteRenderer.sprite = jumpingLeft;
            }
            else if (direction.x > 0)
            {
                spriteRenderer.sprite = jumpingRight;
            }
        }
        else
        {
           
            if (direction.y > 0)
            {
                spriteRenderer.sprite = mainCharacterBack;
            }
            else if (direction.y < 0)
            {
                spriteRenderer.sprite = mainCharacter;
            }
        }
    }

    public void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.transform.position, groundRadius, groundLayer);
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    public void GetPoint()
    {
        Score.singleton.RegisterCoin();
        GetComponent<AudioSource>().Play();
    }

}
