    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class TransformController : MonoBehaviour
    {


        void Start()
        {
        
        }

        float timer = 0f;
        void Update() 
        {
            timer += Time.deltaTime;

        /* Scaling(new Vector3(Mathf.Cos(timer) + 2f, Mathf.Cos(timer) + 2f, Mathf.Cos(timer) + 2f)); = �繰�� ũ�⸦ ���� */
        /*LookGameObject(lookingObject); ������Ʈ �߽����� �ٶ�*/
        /*LookPosition(new Vector3(Mathf.Cos(timer), 0f, Mathf.Sin(timer))); = Ư�� ��ġ�� �߽����� �ٶ�*/
        /*RotateGameObject(new Vector3(0f, (Mathf.Cos(timer) * 0.5f + 0.5f) * 360f, 0f)); = ������Ʈ ȸ��*/
        /*RotateControlForward(new Vector3(Mathf.Cos(timer), 0f, Mathf.Sin(timer))); =  ������Ʈ ȸ��*/
        /* MoveTranslate(new Vector3(0f, Mathf.Cos(timer), 0f)); = ���Ѿ��� ���� �ö󰡱⸸�� */
        /*MovePosition(new Vector3(0f, Mathf.Cos(timer), 0f)); = 0.0.0���� ��ġ�� ������*/
    }

    public void Scaling(Vector3 newScale)
    {
        transform.localScale = newScale;
    }

    [SerializeField]
    private Transform lookingObject;
    public void LookGameObject(Transform lookObj)
        {
        transform.LookAt(lookObj);
        }

    public void LookPosition(Vector3 pos)
    {
        transform.LookAt(pos);
    }

        public void RotateControlForward(Vector3 dir)
    {
        transform.forward = dir;
    }

    public void RotateGameObject(Vector3 rotation)
        {
            transform.rotation = Quaternion.Euler(rotation);
        /* transform.Rotate(rotation); = ������ */
        }

    public void MoveTranslate(Vector3 moveVector)
        {
            transform.Translate(moveVector);
        }

        public void MovePosition(Vector3 newPos)
        {
            transform.position = newPos;
        }
    }
