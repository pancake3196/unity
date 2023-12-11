using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject[] landArray;

    [SerializeField] public GameObject hero;

    [SerializeField] public float UnitSize;

    readonly float speed = 50f;

    readonly float halfSight = 2;


    Vector2[] border;

    private void Start()
    {
        border = new Vector2[]
        {
            new Vector2 (-UnitSize * 1.5f, UnitSize * 1.5f),
            new Vector2 (UnitSize * 1.5f, UnitSize * 1.5f),
        };
    }

    private void Update()
    {
        if (!Input.anyKey)
      return;
        
            


            Vector3 delta;
            switch (Input.inputString)
            {
                case "w":
                    delta = Vector2.up;
                    break;

                case "a":
                    delta = Vector2.left;
                    break;

                case "s":
                    delta = Vector2.down;
                    break;

                case "d":
                    delta = Vector2.right;
                    break;

                default:
                    return;
            }

            delta *= Time.deltaTime * speed;

            hero.transform.position = delta;

            Camera.main.transform.position += delta;

            BoundayCheck();
        }
        void BoundayCheck()
        {
            if (border[1].x < hero.transform.position.x + halfSight)
            {
                border[0] += Vector2.right * UnitSize;
                border[1] += Vector2.right * UnitSize;

                MoveWold(0);
            }
            else if (border[0].x < hero.transform.position.x - halfSight)
            {
                border[0] -= Vector2.up * UnitSize;
                border[1] -= Vector2.up * UnitSize;

                MoveWold(2);
            }
            else if (border[0].y < hero.transform.position.y + halfSight)
            {
                border[0] += Vector2.up * UnitSize;
                border[1] += Vector2.up * UnitSize;

                MoveWold(1);
            }
            else if (border[0].y > hero.transform.position.y - halfSight)
            {
                border[0] -= Vector2.up * UnitSize;
                border[1] -= Vector2.up * UnitSize;

                MoveWold(3);
            }
        }

        void MoveWold(int dir)
        {
            GameObject[] _landArray = new GameObject[9];
            System.Array.Copy(landArray, _landArray, 9);

            switch (dir)
            {
                case 0:
                    for (int i = 0; i < 9; i++)
                    {
                        int revise = i - 3;

                        if (revise < 0)
                        {
                            landArray[9 + revise] = _landArray[i];

                            _landArray[i].transform.position += Vector3.right * UnitSize * 3;
                        }
                        else
                            landArray[revise] = _landArray[i];
                    }
                    break;





                case 1:
                    for (int i = 0; i < 9; i++)
                    {
                        int revise = i % 3;

                        if (revise == 2)
                        {
                            landArray[i - 2] = _landArray[i];
                            _landArray[i].transform.position += Vector3.up * UnitSize * 3;
                        }
                        else
                            landArray[i + 1] = _landArray[i];
                    }
                    break;

                case 2:
                    for (int i = 0; i < 9; i++)
                    {
                        int revise = i + 3;

                        if (revise > 8)
                        {
                            landArray[revise - 9] = _landArray[i];

                            _landArray[i].transform.position -= Vector3.right * UnitSize * 3;
                        }
                        else
                            landArray[revise] = _landArray[i];
                    }
                    break;

                case 3:
                    for (int i = 0; i < 9; i++)
                    {
                        int revise = i % 3;

                        if (revise == 0)
                        {
                            landArray[i + 2] = _landArray[i];

                            _landArray[i].transform.position -= Vector3.up * UnitSize * 3;
                        }
                        else
                            landArray[i - 1] = _landArray[i];
                    }
                    break;
            }
        }
    }
