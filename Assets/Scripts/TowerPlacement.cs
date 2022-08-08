using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    private Tower _placedTower;
    public bool IsPlacing { get; set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_placedTower != null) return;

        Tower tower = collision.GetComponent<Tower>();
        if (tower != null)
        {
            tower.SetPlacePosition(transform.position);
            _placedTower = tower;
            tower.TowerPlacement = this;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_placedTower == null) return;

        _placedTower.SetPlacePosition(null);
        _placedTower = null;
    }
}