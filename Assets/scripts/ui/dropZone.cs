using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
   
    public void OnPointerEnter(PointerEventData eventData)
	{
		//Debug.Log("OnPointerEnter");
		if (eventData.pointerDrag == null)
			return;

		draggable d = eventData.pointerDrag.GetComponent<draggable>();
		if (d != null)
		{
			d.placeholderParent = this.transform;
		}
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		//Debug.Log("OnPointerExit");
		if (eventData.pointerDrag == null)
			return;

		draggable d = eventData.pointerDrag.GetComponent<draggable>();
		if (d != null && d.placeholderParent == this.transform)
		{
			d.placeholderParent = d.parentToReturnTo;
		}
	}

	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);

		draggable d = eventData.pointerDrag.GetComponent<draggable>();
		if (d != null)
		{
			d.parentToReturnTo = this.transform;
         
		}

	}
    
    
}
