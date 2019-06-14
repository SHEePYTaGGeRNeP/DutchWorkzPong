using UnityEngine;
public class PanelController : MonoBehaviour
{
    //[SerializeField]
    //private Vector2 _bounds;
    [SerializeField]
    private float _speed = 3f;

    private Rigidbody2D _rb;

    private void Awake()
    {
        this._rb = this.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        float add = y * Time.deltaTime * this._speed;
        this._rb.MovePosition(new Vector2(this.transform.position.x, this.transform.position.y + add));
    }

}
