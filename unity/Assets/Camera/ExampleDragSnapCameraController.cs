using UnityEngine;
using System;

public class ExampleDragSnapCameraController : MonoBehaviour
{
    private DragSnapCamera dragSnapCamera;

    void Awake()
    {
        dragSnapCamera = Ensure.Component<DragSnapCamera>( this );
    }

    void Start()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag( "Snap" );
        Transform[] snapPoints = Array.ConvertAll<GameObject,Transform>( gos, go => go.transform );

        if( snapPoints.Length > 0 ) {
            print( "Setting snap points" );
            dragSnapCamera.SnapPoints = snapPoints;
            dragSnapCamera.DefaultSnapPoint = snapPoints[0];
            dragSnapCamera.MoveToDefaultSnapPoint();
        }
    }



}