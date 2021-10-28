using UnityEngine;

public sealed class CurveGenerator : MonoBehaviour
{
    [SerializeField] private AnimationCurve BaseGraph;
    public float I = 0;
    [SerializeField] private float Height = 0;
    [SerializeField] private float Speed = 0.05f;
    [SerializeField] private float Noise = 0.1f;
    public static CurveGenerator instance { get; private set; }

    private void Awake() => instance = this;
    public float MoveNext()
    {
        I += Speed;

        return BaseGraph.Evaluate(I) + AddNoise() + Height;
    }
    private float AddNoise()
    {
        return Random.Range(-Noise, Noise);
    }
}
