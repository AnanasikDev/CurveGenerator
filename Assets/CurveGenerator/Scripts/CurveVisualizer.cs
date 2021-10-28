using UnityEngine;
public class GraphVisualizer : MonoBehaviour
{
    [SerializeField] private AnimationCurve VisualizationCurve = new AnimationCurve();
    [SerializeField] private float TimeTick = 0.04f;
    private void Start()
    {
        InvokeRepeating("Visualize", TimeTick, TimeTick);
    }
    private void Visualize()
    {
        float a = GraphGenerator.instance.MoveNext();

        VisualizationCurve.AddKey(GraphGenerator.instance.I, a);
    }
}
