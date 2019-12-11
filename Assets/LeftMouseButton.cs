using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LeftMouseButton : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine(CheckLeftMouse());
    }

    IEnumerator CheckLeftMouse()
    {
        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                text.enabled = true;
                yield return new WaitForSeconds(1);
                text.enabled = false;
            }
            yield return null;
        }
    }
}
