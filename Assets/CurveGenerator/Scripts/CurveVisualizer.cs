using UnityEngine;
public class CurveVisualizer : MonoBehaviour
{
    [SerializeField] private AnimationCurve VisualizationCurve = new AnimationCurve();
    [SerializeField] private float TimeTick = 0.04f;
    private void Start()
    {
        InvokeRepeating("Visualize", 1, TimeTick);
    }
    private void Visualize()
    {
        float a = CurveGenerator.instance.MoveNext();

        VisualizationCurve.AddKey(CurveGenerator.instance.I, a);
    }
}
