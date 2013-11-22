using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	/// <summary>
	/// 摄像机
	/// </summary>
	private Transform m_Transform;
	/// <summary>
	/// 摄像机旋转角度
	/// </summary>
	private Vector3 m_Rotate;
	/// <summary>
	/// 角色控制器
	/// </summary>
	private CharacterController m_character;
	// Use this for initialization
	void Start () {
		m_Transform=this.transform;
		m_character=GetComponent<CharacterController>();
		m_Rotate=m_Transform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		float x=Input.GetAxis("Horizontal");
		float z=Input.GetAxis("Vertical");
		m_character.Move(m_Transform.TransformDirection(new Vector3(x,0,z)));

		float mouseX=Input.GetAxis("Mouse X");
		float mouseY=Input.GetAxis("Mouse Y");
		m_Rotate.x-=mouseY;
		m_Rotate.y+=mouseX;
		m_Transform.eulerAngles=m_Rotate;
	}
}
