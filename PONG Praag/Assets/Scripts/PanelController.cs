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
    protected virtual void Update()
    {
        float y = Input.GetAxis("Vertical");
        this.MoveInput(y);
    }

    public void MoveInput(float y)
    {
        y = Mathf.Clamp(y, -1f, 1f);
        float add = y * Time.deltaTime * this._speed;
        float finalPositionY = this.transform.position.y + add;
        finalPositionY = Mathf.Clamp(finalPositionY, this._boundsY.x, this._boundsY.y);
        this._rb.MovePosition(new Vector2(this.transform.position.x, finalPositionY));

    }

}
