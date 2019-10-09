using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;

public class virtualjoystick : MonoBehaviour, IDragHandler,IPointerUpHandler,IPointerDownHandler {

	private Image bgImage;
	private Image joystickImage;
	private Vector3 inputVector;

	private void Start()
	{
		bgImage = GetComponent<Image> ();
		joystickImage = transform.GetChild (0).GetComponent<Image> ();
	}
	public virtual void OnDrag(PointerEventData ped)
	{
		Vector2 pos;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle (bgImage.rectTransform, 
			ped.position, 
			ped.pressEventCamera, 
			out pos)) 
		{
			pos.x = (pos.x / bgImage.rectTransform.sizeDelta.x);
			pos.y = (pos.y / bgImage.rectTransform.sizeDelta.y);

			float x = (bgImage.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
			float y = (bgImage.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;

			inputVector = new Vector3(x, 0, y);
			inputVector = (inputVector.magnitude > 1) ? inputVector.normalized : inputVector;

			joystickImage.rectTransform.anchoredPosition = 
				new Vector3 (inputVector.x * (bgImage.rectTransform.sizeDelta.x / 3),
					inputVector.z * (bgImage.rectTransform.sizeDelta.y / 3));
		}
	}
	public virtual void OnPointerDown(PointerEventData ped)
	{
		OnDrag (ped);
	}
	public virtual void OnPointerUp(PointerEventData ped)
	{
		inputVector = Vector3.zero;
		joystickImage.rectTransform.anchoredPosition = Vector3.zero;
	}
	public float Horizontal()
	{
		if (inputVector.x != 0) {
			return inputVector.x;
		} else
			return Input.GetAxis ("Horizontal");
	}
	public float Vertical()
	{
		if (inputVector.z != 0) {
			return inputVector.z;
		} else
			return Input.GetAxis ("Vertical");
	}
}
