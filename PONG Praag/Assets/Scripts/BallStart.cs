using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallStart : MonoBehaviour
{
    [SerializeField]
    private float _force = 10;
    // Start is called before the first frame update
    void Start()
    {
        this.StartCoroutine(AddForce());
    }
    private IEnumerator AddForce()
    {
        yield return new WaitForSeconds(0.5f);
        Vector2 randVector = new Vector2(Random.Range(0.1f, 1), Random.Range(0.1f, 1));
        for (int i = 0; i < 10; i++)
        {
            this.GetComponent<Rigidbody2D>().AddForce(randVector.normalized * this._force, ForceMode2D.Impulse);
            yield return new WaitForEndOfFrame();
        }
    }
}
