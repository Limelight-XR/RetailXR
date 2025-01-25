using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour
{
    [Header("Positions")]
    [SerializeField] private Vector3 valleyPosition;
    [SerializeField] private Vector3 peakPosition;

    [Header("Timing")]
    [SerializeField] private float period;

    private void OnEnable()
    {
        StartCoroutine(IOscillate());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
        this.transform.localPosition = valleyPosition;
    }

    private IEnumerator IOscillate()
    {
        yield return this.transform.DOLocalMove(peakPosition, period / 2).WaitForCompletion();
        yield return this.transform.DOLocalMove(valleyPosition, period / 2).WaitForCompletion();

        StartCoroutine(IOscillate());
    }
}
