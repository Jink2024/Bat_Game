using UnityEngine;

using System.Collections;
using UnityEngine;

public class InsectGameEchoTrail : MonoBehaviour
{
    public float fadeDuration = 0.5f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeOut()
    {
        Color color = spriteRenderer.color;
        float elapsed = 0f;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            color.a = Mathf.Lerp(1f, 0f, elapsed / fadeDuration);
            spriteRenderer.color = color;
            yield return null;
        }

        Destroy(gameObject);
    }
}