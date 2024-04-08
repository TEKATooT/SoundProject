using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] private Text _text;

    private Coroutine newCoroutine;
    private float _counterStep = 0.5f;
    private float _counterTimer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (newCoroutine == null)
            {
                newCoroutine = StartCoroutine(nameof(StartCounter));
            }
            else
            {
                StopCoroutine(newCoroutine);
                newCoroutine = null;
            }
        }
    }

    private IEnumerator StartCounter()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_counterStep);

        while (true)
        {
            _counterTimer++;
            _text.text = _counterTimer.ToString();

            yield return waitForSeconds;
        }
    }
}
