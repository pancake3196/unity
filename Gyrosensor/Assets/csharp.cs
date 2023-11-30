using UnityEngine;

public class GyroController : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    void Start()
    {
        // ��Ⱑ ���̷μ����� �����ϴ��� Ȯ��
        gyroEnabled = SystemInfo.supportsGyroscope;

        if (gyroEnabled)
        {
            gyro = Input.gyro;
            gyro.enabled = true; // ���̷μ��� Ȱ��ȭ
            Input.gyro.updateInterval = 0.0167f; // ���̷μ��� ������Ʈ ���� ����
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
            // ���̷μ��� ���� �̿��Ͽ� ȸ��
            Quaternion gyroAttitude = gyro.attitude;

            // �޴����� ȭ���� �Ʒ��� ���� ���� ���̷μ��� �� ���
            Quaternion phoneOrientation = Quaternion.Euler(-90f, 0f, 0f);
            Quaternion rotatedGyroAttitude = phoneOrientation * gyroAttitude;

            // GameObject�� ȸ���� ����
            transform.rotation = rotatedGyroAttitude;
        }
    }
}
