using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Sprite[] rightSprites;
    public Sprite[] leftSprites;
    public Sprite[] upSprites;
    public Sprite[] downSprites;

    private SpriteRenderer spriteRenderer;
    private Vector2 lastDirection;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        lastDirection = Vector2.right; // начальное направление персонажа
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontalInput, verticalInput).normalized;

        if (direction != Vector2.zero)
        {
            lastDirection = direction;
        }

        if (direction.x > 0)
        {
            spriteRenderer.sprite = rightSprites[Random.Range(0, rightSprites.Length)];
        }
        else if (direction.x < 0)
        {
            spriteRenderer.sprite = leftSprites[Random.Range(0, leftSprites.Length)];
        }
        else if (direction.y > 0)
        {
            spriteRenderer.sprite = upSprites[Random.Range(0, upSprites.Length)];
        }
        else if (direction.y < 0)
        {
            spriteRenderer.sprite = downSprites[Random.Range(0, downSprites.Length)];
        }
    }
}
