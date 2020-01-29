using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent OnOverEvent;
    public UnityEvent OnOffEvent;
    public UnityEvent OnClickEvent;

    bool m_bDown;
    bool m_blastDown;

    public void Down()
    {
        m_bDown = true;
    }
    public void Clicked()
    {
        OnClickEvent.Invoke();
    }
    void Update()
    {
        if (m_bDown && !m_blastDown)
        {
            OnOverEvent.Invoke();
        }
        if (!m_bDown && m_blastDown)
        {
            OnOffEvent.Invoke();
        }
        m_blastDown = m_bDown;
        m_bDown = false;
    }
}
