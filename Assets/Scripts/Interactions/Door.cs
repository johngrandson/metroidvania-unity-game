using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] public GameObject door;
    private GameObject GO;

    private void Start()
    {
        if (door != null)
        {
            GO = GetComponent<GameObject>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GO.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GO.SetActive(false);
        }
    }
}
