using UnityEngine;

public class GyroController : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    void Start()
    {
        // 기기가 자이로센서를 지원하는지 확인
        gyroEnabled = SystemInfo.supportsGyroscope;

        if (gyroEnabled)
        {
            gyro = Input.gyro;
            gyro.enabled = true; // 자이로센서 활성화
            Input.gyro.updateInterval = 0.0167f; // 자이로센서 업데이트 간격 설정
        }
        else
        {
            Debug.LogWarning("Your device doesn't support gyroscope.");
        }
    }

    void Update()
    {
        if (gyroEnabled)
        {
            // 자이로센서 값을 이용하여 회전
            Quaternion gyroAttitude = gyro.attitude;

            // 휴대폰의 화면이 아래를 향할 때의 자이로센서 값 계산
            Quaternion phoneOrientation = Quaternion.Euler(-90f, 0f, 0f);
            Quaternion rotatedGyroAttitude = phoneOrientation * gyroAttitude;

            // GameObject의 회전을 적용
            transform.rotation = rotatedGyroAttitude;
        }
    }
}
