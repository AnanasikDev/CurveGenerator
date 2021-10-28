using UnityEngine;

public sealed class GraphGenerator : MonoBehaviour
{
    [SerializeField] private AnimationCurve BaseGraph;
    public float I = 0;
    [SerializeField] private float Speed = 0.05f;

    public static GraphGenerator instance { get; private set; }

    private void Awake() => instance = this;
    public float MoveNext()
    {
        I += Speed;

        return BaseGraph.Evaluate(I);
    }
}
