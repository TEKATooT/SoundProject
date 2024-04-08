using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] private Text _text;

    private Coroutine _coroutine;
    private float _counterStep = 0.5f;
    private float _counterTimer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_coroutine == null)
            {
                _coroutine = StartCoroutine(nameof(Begin));
            }
            else
            {
                StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }
    }

    private IEnumerator Begin()
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