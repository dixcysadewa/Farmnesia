using UnityEngine;
using System.Collections;

public class Crop : MonoBehaviour
{
    [Header("Growth Sprites")]
    public Sprite stage1;
    public Sprite stage2;
    public Sprite stage3;
    public Sprite stage4;

    [Header("Growth Time")]
    public float stageTime = 10f;

    private SpriteRenderer sr;

    private int currentStage = 1;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        sr.sprite = stage1;

        StartCoroutine(Grow());
    }

    IEnumerator Grow()
    {
        yield return new WaitForSeconds(stageTime);

        currentStage = 2;
        sr.sprite = stage2;

        yield return new WaitForSeconds(stageTime);

        currentStage = 3;
        sr.sprite = stage3;

        yield return new WaitForSeconds(stageTime);

        currentStage = 4;
        sr.sprite = stage4;

        Debug.Log("Tanaman siap dipanen!");
    }

    public bool IsReady()
    {
        return currentStage == 4;
    }
}