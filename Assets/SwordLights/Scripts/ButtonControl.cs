using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public UnityEngine.EventSystems.EventSystem eventSystem;
    UnityEngine.UI.Button button;

    private void Start()
    {
        //button = gameObject.GetComponent<UnityEngine.UI.Button>();
    }
    public void Click()
    {
        UnityEngine.EventSystems.ExecuteEvents.Execute(gameObject, new UnityEngine.EventSystems.
            BaseEventData(eventSystem), UnityEngine.EventSystems.ExecuteEvents.submitHandler);
    }
    public void Over()
    {
        UnityEngine.EventSystems.ExecuteEvents.Execute(gameObject, new UnityEngine.EventSystems.
            PointerEventData(eventSystem), UnityEngine.EventSystems.ExecuteEvents.pointerEnterHandler);
    }
    public void Off()
    {
        UnityEngine.EventSystems.ExecuteEvents.Execute(gameObject, new UnityEngine.EventSystems.
            PointerEventData(eventSystem), UnityEngine.EventSystems.ExecuteEvents.pointerExitHandler);
    }
}
