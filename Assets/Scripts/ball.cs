using UnityEngine;

public class ball : MonoBehaviour
{
   public new Rigidbody2D rigidbody {  get; private set; }
    
    public float speed = 500f;

    public void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Start()
    {
        ResetBall();
    }

    public void ResetBall()
    {
        this.transform.position = Vector2.zero;
        this.rigidbody.velocity = Vector2.zero;

        Invoke(nameof(SetRandomTrajectory), 1f);

    }
    private void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;

        this.rigidbody.AddForce(force.normalized * this.speed);
    }
}
