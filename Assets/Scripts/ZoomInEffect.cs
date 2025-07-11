using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ZoomInEffect : MonoBehaviour
{
    public Transform kickText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            kickText.DOScale(100f, 8f).OnComplete(() =>
            {
                kickText.gameObject.SetActive(false);

                SceneManager.LoadScene("Story");
            });
        }
    }
}
