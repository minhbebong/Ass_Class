using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class MapGenerator : MonoBehaviour
{
    [SerializeField]
    private Tilemap map;
    [SerializeField]
    private List<TileBase> groundList;
    [SerializeField]
    private Transform playerPosition;
    [SerializeField]
    private int radius;

    [SerializeField]
    private int playerStep;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int x = -radius; x < radius; x++) 
        {
            for (int y = -radius; y < radius; y++)
            {
                Vector3Int tileCell = new Vector3Int(x + playerStep + (int)playerPosition.position.x, y + playerStep + (int)playerPosition.position.y);
                
                if(map.GetTile(tileCell) == null)
                {
                    var tilePosition = map.WorldToCell(tileCell);
                    map.SetTile(tilePosition, groundList[Random.Range(0, groundList.Count)]);
                }
            }
        }
    }


}
