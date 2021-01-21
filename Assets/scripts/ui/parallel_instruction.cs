using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class parallel_instruction : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public GameObject minirung = null;

	public Transform parentToReturnTo = null ;


	public void OnBeginDrag(PointerEventData eventData)
	{
		Debug.Log("OnBeginDrag");

		parentToReturnTo = this.transform.parent;
		this.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);

		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		//Debug.Log ("OnDrag");
	    this.transform.position = eventData.position;


	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log("OnEndDrag");
		this.transform.SetParent(parentToReturnTo);
		GetComponent<CanvasGroup>().blocksRaycasts = true;

		Destroy(this.gameObject);
		
	}


	}


