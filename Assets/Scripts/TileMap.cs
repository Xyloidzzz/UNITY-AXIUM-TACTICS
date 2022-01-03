using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {

    public TileType[] tileTypes;

    int[, ] tiles;

    int mapSizeX = 10;
    int mapSizeY = 10;

    // Start is called before the first frame update
    void Start () {
        // Allocate map tiles
        tiles = new int[mapSizeX, mapSizeY];

        // Initialize map tiles
        for (int x = 0; x < mapSizeX; x++) {
            for (int y = 0; y < mapSizeY; y++) {
                tiles[x, y] = 0;
            }
        }
        GenerateMapVisual ();
    }

    void GenerateMapVisual () {
        for (int x = 0; x < mapSizeX; x++) {
            for (int y = 0; y < mapSizeY; y++) {
                TileType tt = tileTypes[tiles[x, y]];
                Instantiate (tt.tileVisualPrefab, new Vector3 (x, y, 0), Quaternion.identity);
            }
        }
    }

}