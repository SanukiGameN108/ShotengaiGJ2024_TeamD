using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class BGImageGenerator : MonoBehaviour
{
    [SerializeField] private Sprite[] bgImages;
    [SerializeField] private Sprite abyssBGImage;

    private SpriteRenderer bgRenderer;
    private SpriteRenderer abyssBGRenderer;

    void Start()
    {
        bgRenderer = GetComponent<SpriteRenderer>();
        
        if (bgRenderer == null)
        {
            Debug.LogError("SpriteRenderer コンポーネントが見つかりません。");
            return;
        }

        GameObject abyssBGObject = new GameObject("AbyssBackground");
        abyssBGObject.transform.parent = transform;
        abyssBGObject.transform.localPosition = Vector3.zero;
        abyssBGRenderer = abyssBGObject.AddComponent<SpriteRenderer>();

        // NOTE: abyssBGRendererをbgRendererより前面に表示するためにsortingOrderを設定
        abyssBGRenderer.sortingOrder = bgRenderer.sortingOrder + 1;

        SetRandomBackground();
        SetAbyssBackground();
    }

    void SetRandomBackground()
    {
        if (bgImages == null || bgImages.Length == 0)
        {
            Debug.LogWarning("BGImageGeneratorに背景画像が設定されていません。");
            return;
        }

        int randomIndex = Random.Range(0, bgImages.Length);
        Sprite selectedImage = bgImages[randomIndex];
        bgRenderer.sprite = selectedImage;

        Color color = bgRenderer.color;
        // NOTE: アルファ値を設定して画像を透過
        color.a = 0.8f;
        bgRenderer.color = color;

        // サイズを設定
        transform.localScale = new Vector3(32f, 32f, 32f);
    }

    void SetAbyssBackground()
    {
        if (abyssBGImage == null)
        {
            Debug.LogWarning("BGImageGeneratorにabyssBGImageが設定されていません。");
            return;
        }

        abyssBGRenderer.sprite = abyssBGImage;
        abyssBGRenderer.color = Color.black;
        abyssBGRenderer.transform.localScale = new Vector3(1f * StageConstants.GROUND_X_COUNT + 16f, 1f, 1f);

        abyssBGRenderer.transform.localPosition = new Vector3(0f, -3.8f, 0f);
    }
}
