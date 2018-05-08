using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {


    private const float TILE_SIZE = 1.0f;
    private Vector3 cameraPos;
    private float screenSideLength = 10f;
    private Camera mainCamera;
    void Start () {

        cameraPos = new Vector3(screenSideLength / 2, screenSideLength / 2, -screenSideLength / 2);
        mainCamera = Camera.main;
        mainCamera.transform.position = cameraPos;
	}

    private void DrawGrid()
    {
        // If I ever need to scale based on player view range
        float scale = 1;
        Vector2 widthLine = Vector2.right * scale * screenSideLength * TILE_SIZE;
        Vector2 heightLine = Vector2.up * scale * screenSideLength * TILE_SIZE;


        for (int i = 0; i <= scale * screenSideLength; i += 1)
        {
            Vector2 start = Vector2.right * i;
            Debug.DrawLine(start, start + heightLine, Color.white, 1, true);
        }

        for (int j = 0; j <= scale * screenSideLength; j += 1)
        {
            Vector2 start = Vector2.up * j;
            Debug.DrawLine(start, start + widthLine, Color.white, 1, true);
        }
    }


    void Update () {
        DrawGrid();
	}
}
