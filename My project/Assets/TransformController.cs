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

        /* Scaling(new Vector3(Mathf.Cos(timer) + 2f, Mathf.Cos(timer) + 2f, Mathf.Cos(timer) + 2f)); = 사물의 크기를 조절 */
        /*LookGameObject(lookingObject); 오브젝트 중심으로 바라봄*/
        /*LookPosition(new Vector3(Mathf.Cos(timer), 0f, Mathf.Sin(timer))); = 특정 위치를 중심으로 바라봄*/
        /*RotateGameObject(new Vector3(0f, (Mathf.Cos(timer) * 0.5f + 0.5f) * 360f, 0f)); = 오브젝트 회전*/
        /*RotateControlForward(new Vector3(Mathf.Cos(timer), 0f, Mathf.Sin(timer))); =  오브젝트 회전*/
        /* MoveTranslate(new Vector3(0f, Mathf.Cos(timer), 0f)); = 제한없이 위로 올라가기만함 */
        /*MovePosition(new Vector3(0f, Mathf.Cos(timer), 0f)); = 0.0.0으로 위치가 고정됨*/
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
        /* transform.Rotate(rotation); = 빠르게 */
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
