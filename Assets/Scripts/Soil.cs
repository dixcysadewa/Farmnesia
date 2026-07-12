using UnityEngine;

public class Soil : MonoBehaviour
{
    [Header("Sprites")]
    public Sprite normalSoil;
    public Sprite tilledSoil;

    [Header("Settings")]
    public KeyCode hoeKey = KeyCode.E;

    private SpriteRenderer sr;

    private bool playerNearby = false;
    private bool isTilled = false;

    // Referensi ke ToolManager
    private ToolManager toolManager;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        toolManager = FindFirstObjectByType<ToolManager>();
    }

    void Update()
    {
        if (playerNearby &&
            Input.GetKeyDown(hoeKey) &&
            toolManager != null &&
            toolManager.currentTool == ToolManager.Tool.Hoe)
        {
            HoeSoil();
        }
    }

    void HoeSoil()
    {
        if (isTilled)
            return;

        isTilled = true;

        sr.sprite = tilledSoil;

        Debug.Log(gameObject.name + " berhasil dicangkul");
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