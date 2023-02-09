using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirdManager : MonoBehaviour
{
    [SerializeField] private GameObject _tilePrefab;
    [SerializeField] private Vector2Int _gridSize;
    [SerializeField] private float _offset;
    [SerializeField] private Transform _parent;
    [SerializeField] private Transform _startPosition;

    Dictionary<string, Vector2> cellPosition = new Dictionary<string, Vector2>();

    private void GenerateGrid()
    {
        //var _cellsize = _tilePrefab.GetComponent<SpriteRenderer>().bounds.size;
        for (float x = 0; x < _gridSize.x; x++)
        { for (float y = 0; y < _gridSize.y; y++)
            {
                var position = (Vector2)_startPosition.position + new Vector2(x * (_gridSize.x * _offset), y * (_gridSize.y * _offset));
                var cell = Instantiate(_tilePrefab, position, Quaternion.identity, _parent);
                cell.name = $"{x}{y}";
                cellPosition.Add(cell.name, position);
                //Debug.Log(cell.name);
                //Debug.Log(position);
            }
        }
    }


    void Start()
    {
        GenerateGrid();
    }


}
