using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirdGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _tilePrefab;
    [SerializeField] private Vector2Int _gridSize;
    [SerializeField] private float _offset;
    [SerializeField] private Transform _parent;

        private void GenerateGrid()
    {
        //var _cellsize = _tilePrefab.GetComponent<SpriteRenderer>().bounds.size;
        for (int x = 0; x < _gridSize.x; x++)
        { for (int y = 0; y < _gridSize.y; y++)
            {
                var position = new Vector2(x * (_gridSize.x + _offset), y * (_gridSize.y + _offset));
                var cell = Instantiate(_tilePrefab, position, Quaternion.identity, _parent);
                cell.name = $" X: {x},Y: {y}";
            }
        }
    }

    void Start()
    {
        GenerateGrid();
    }


}
