using UnityEngine;
public class PanelController : MonoBehaviour
{
    [SerializeField]
    private Vector2 _boundsY = new Vector2(-2.1f, 2.1f);
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
        float finalPositionY = this.transform.position.y + add;
        finalPositionY = Mathf.Clamp(finalPositionY, this._boundsY.x, this._boundsY.y);
        this._rb.MovePosition(new Vector2(this.transform.position.x, finalPositionY));
    }

}
