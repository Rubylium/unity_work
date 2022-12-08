using UnityEngine;
using UnityEngine.EventSystems;

public class mouvements : MonoBehaviour
{
    private float playerSpeed = 5.0f;
    private float jumpPower = 5.0f;
    private bool moveLeft;
    private bool moveRight;
    
    private Rigidbody2D _playerRigidbody;
    private void Start()
    {
        _playerRigidbody = GameObject.Find("Body").GetComponent<Rigidbody2D>();
        if (_playerRigidbody == null)
        {
            Debug.LogError("Player is missing a Rigidbody2D component");
        }
    }
    private void Update()
    {
        if(moveLeft && !moveRight)
            _playerRigidbody.velocity = new Vector2(-1 * playerSpeed, _playerRigidbody.velocity.y); 
 
        if(moveRight && !moveLeft)
            _playerRigidbody.velocity = new Vector2(1 * playerSpeed, _playerRigidbody.velocity.y); 
    }
    public void Jump() => _playerRigidbody.velocity = new Vector2( 0, jumpPower);

    public void GoLeftStart()
    {
        moveLeft = true;
    }

    public void GoLeftStop()
    {
        moveLeft = false;
    }
    
    public void GoRightStart()
    {
        moveRight = true;
    }

    public void GoRightStop()
    {
        moveRight = false;
    }

}