#region "Imports"
using UnityEngine;
using UnityEditor;
#endregion


[CustomEditor(typeof(GSDSplineI))]
public class GSDSplineIEditor : Editor
{
    protected GSDSplineI tSpline { get { return (GSDSplineI) target; } }


    public override void OnInspectorGUI()
    {
        //Intentionally left empty.
    }
}