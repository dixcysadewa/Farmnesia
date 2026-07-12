using UnityEngine;

public class Soil : MonoBehaviour
{
    [Header("Sprites")]
    public Sprite normalSoil;
    public Sprite tilledSoil;

    [Header("Plant Prefabs")]
    public GameObject carrotPrefab;
    public GameObject tomatoPrefab;
    public GameObject cornPrefab;
    public GameObject potatoPrefab;
    public GameObject cabbagePrefab;
    public GameObject chiliPrefab;

    public Transform plantPoint;

    [Header("Settings")]
    public KeyCode actionKey = KeyCode.E;

    private SpriteRenderer sr;
    private Hotbar hotbar;

    private bool playerNearby = false;
    private bool isTilled = false;
    private bool isPlanted = false;

    private GameObject currentPlant;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        hotbar = FindFirstObjectByType<Hotbar>();
    }

    private void Update()
    {
        if (!playerNearby)
            return;

        if (!Input.GetKeyDown(actionKey))
            return;

        if (hotbar == null)
            return;

        switch (hotbar.GetCurrentItem())
        {
            case ItemType.Hoe:
                HoeSoil();
                break;

            case ItemType.CarrotSeed:
                PlantSeed(carrotPrefab);
                break;

            case ItemType.TomatoSeed:
                PlantSeed(tomatoPrefab);
                break;

            case ItemType.CornSeed:
                PlantSeed(cornPrefab);
                break;

            case ItemType.PotatoSeed:
                PlantSeed(potatoPrefab);
                break;

            case ItemType.CabbageSeed:
                PlantSeed(cabbagePrefab);
                break;

            case ItemType.ChiliSeed:
                PlantSeed(chiliPrefab);
                break;
        }
    }

    private void HoeSoil()
    {
        if (isTilled)
            return;

        isTilled = true;
        sr.sprite = tilledSoil;

        Debug.Log(gameObject.name + " berhasil dicangkul");
    }

    private void PlantSeed(GameObject cropPrefab)
    {
        if (!isTilled)
            return;

        if (isPlanted)
            return;

        if (cropPrefab == null)
        {
            Debug.LogWarning("Prefab tanaman belum diisi!");
            return;
        }

        if (plantPoint == null)
        {
            Debug.LogWarning("Plant Point belum diisi!");
            return;
        }

        isPlanted = true;

        currentPlant = Instantiate(
            cropPrefab,
            plantPoint.position,
            Quaternion.identity);

        Debug.Log("Benih berhasil ditanam");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
        }
    }
}