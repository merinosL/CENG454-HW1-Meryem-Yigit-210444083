using UnityEngine;

public class FlightController : MonoBehaviour
{
    [SerializeField] private float pitchSpeed = 45f;
    [SerializeField] private float yawSpeed = 45f;
    [SerializeField] private float rollSpeed = 45f;
    [SerializeField] private float thrustSpeed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // YENİ EKLENEN KISIM: Input'ları hocanın istediği gibi Update içine alıyoruz
    void Update()
    {
        HandleRotation();
    }

    private void HandleRotation()
    {
        // Pitch (Aşağı/Yukarı): Hocanın ödevde özellikle istediği Vector3.right ve transform.Rotate kullanımı
        float pitchInput = Input.GetAxis("Vertical"); 
        transform.Rotate(Vector3.right * pitchInput * pitchSpeed * Time.deltaTime);
    }
}